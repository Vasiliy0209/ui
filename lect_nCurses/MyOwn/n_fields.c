# include <form.h>
# define N_FIELDS 3

int main(int argc, char *argv[])
{
    FORM *myform;
    FIELD *field[N_FIELDS+1];
    int i,ch;
    
    initscr();
    start_color();
    noecho();
    cbreak();
    keypad(stdscr,TRUE);
    
    init_pair(1,COLOR_RED,COLOR_WHITE);
    
    for(i=0;i<N_FIELDS;i++) {
	field[i]=new_field(1,10,3+i*2,12,0,0);
	set_field_type(field[i],TYPE_INTEGER,0,0,10);
	set_field_back(field[i],COLOR_PAIR(1));
    }
    
    field[N_FIELDS]=NULL;
    
    myform=new_form(field);
    post_form(myform);
    refresh();
    
    for(i=0;i<N_FIELDS;i++) 
	mvprintw(3+i*2,2,"Field %d",i);
    
    mvprintw(LINES-1,0,"Press ENTER to terminate input");
    
    for(;;) {
	ch=getch();
	switch(ch) {
	    case KEY_DOWN: {
		if(form_driver(myform,REQ_NEXT_FIELD)==E_INVALID_FIELD)
		    mvprintw(LINES-1,0,"Wrong data\a");
		break;
	    }
	    case KEY_UP: {
		form_driver(myform,REQ_PREV_FIELD);
		break;
	    }
	    case KEY_BACKSPACE: {
		//mvprintw(LINES-1,0,"Back");
		form_driver(myform,REQ_DEL_PREV);
		break;
	    }
	    case 10: {
		form_driver(myform,REQ_NEXT_FIELD);
		mvprintw(LINES-N_FIELDS-2,0,"Data from form:");
		for(i=N_FIELDS-1;i>=0;i--)
		   mvprintw(LINES-(N_FIELDS-i)-1,0,"Field%d = %s",i,field_buffer(field[i],0)); 
		break;
	    }
	    default: {
		form_driver(myform,ch);
		break;
	    }
	}
    }
    
    endwin();
    return 0;
}
