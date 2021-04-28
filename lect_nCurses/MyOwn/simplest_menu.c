# include <ncurses.h>
# include <menu.h>

int main()
{
    ITEM *myitems[4];
    MENU *my_menu;
    
    int k;
    k=4;
    myitems[0]=new_item("One","");set_item_userptr(myitems[0],&k);
    myitems[1]=new_item("Two","");
    myitems[2]=new_item("Three","");
    myitems[3]=(ITEM *)NULL;
    
    initscr();
    noecho();
    keypad(stdscr,true);
    my_menu=new_menu((ITEM **)myitems);
    post_menu(my_menu);
    refresh();
    
    //printf("LINES %d\n",LINES);
    int c;
    for(;;) {
	//c=getch();
	//printf("[%d] [%d] [%d]\n\r",KEY_UP,c,KEY_UP==c);
	switch((int)getch()) {
	    case KEY_UP: {
		menu_driver(my_menu,REQ_UP_ITEM);
		break;
	    }
	    case KEY_DOWN: {
		menu_driver(my_menu,REQ_DOWN_ITEM);		
		break;
	    }
	    
	    
	    case 10: {
		move(LINES-1,0);
		clrtoeol();
		
		int *v;
		v=item_userptr(current_item(my_menu));
		mvprintw(LINES-1,0, "ENTER PRESSED %d",*v);
		
		//mvprintw(LINES-1,0, "ENTER PRESSED %s",item_name(current_item(my_menu)));
		break;
	    }
							
	    /*case 10: {
		if(item_value(myitems[0])==TRUE)
		   mvprintw(LINES-1,0,"YES");
		else
		   mvprintw(LINES-1,0,"NO");
		//mvprintw(LINES-1,0,"GO");
		break;
	    }*/
	    
	    case 'q': {
		return 0;
	    }
	}
	//printf("!\n");
    }
    
    endwin();
    return 0;
}
