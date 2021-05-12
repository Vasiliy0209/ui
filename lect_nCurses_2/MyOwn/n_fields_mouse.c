# include <form.h>
# include <menu.h>
# define N_FIELDS 3

int main(int argc, char *argv[])
{
    MEVENT event;
    
    WINDOW *w;
    
    FORM *myform;
    FIELD *field[N_FIELDS+1];
    MENU *mymenu;
    ITEM *items[3];
    items[0]=new_item("[  OK  ]","");
    items[1]=new_item("[Cancel]","");
    items[2]=NULL;
    
    int i,ch;
    
    initscr();
    start_color();
    noecho();
    cbreak();
    mousemask(ALL_MOUSE_EVENTS,NULL);
    keypad(stdscr,TRUE);
    
    w=newwin(3,3,10,10);
    box(w,0,0);
    
    init_pair(1,COLOR_RED,COLOR_WHITE);
    
    for(i=0;i<N_FIELDS;i++) {
	field[i]=new_field(1,10,3+i*2,12,0,0);
	set_field_back(field[i],COLOR_PAIR(1));
    }
    
    field[N_FIELDS]=NULL;
    
    mymenu=new_menu(items);
    set_menu_win(mymenu,w);
    post_menu(mymenu);
    
    wrefresh(w);
    //getch();
    
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
		form_driver(myform,REQ_NEXT_FIELD);
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
	    case KEY_MOUSE: {
		form_driver(myform,KEY_MOUSE);
		
		mvprintw(LINES-1,0,"Mouse pressed");
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
