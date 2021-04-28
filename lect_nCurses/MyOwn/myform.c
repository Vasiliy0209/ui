# include <form.h>

int main(int argc, char *argv[])
{
    FIELD *field[2];
    FORM *myform;
    int ch;
    initscr();
    start_color();
    noecho();
    
    field[0]=new_field(1,14,5,10,0,0);
    field[1]=new_field(1,14,7,10,0,0);
    field[2]=NULL;
    
    init_pair(1,COLOR_MAGENTA, COLOR_CYAN);
    set_field_back(field[0],COLOR_PAIR(1));
    
    myform=new_form(field);
    post_form(myform);
    refresh();
    
    for(;;) {
	ch=getch();
	switch(ch) {
	    case 10: {
		form_driver(myform,REQ_NEXT_FIELD);
		mvprintw(LINES-1,0,"Got value: [%s]",field_buffer(field[0],0));
		
		break;
	    }
	    default: {form_driver(myform,ch);break;}
	}
    }
    endwin();
    return 0;
}
