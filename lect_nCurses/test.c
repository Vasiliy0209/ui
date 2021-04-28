# include <ncurses.h>
# include <menu.h>

int main(int argc, char *argv[])
{
    ITEM *items[4];
    MENU *menu;
    int ch;
    int i,values[3],*curr_item;
    
    initscr();
    keypad(stdscr,TRUE);
    
    
    
    items[0]=new_item("One","");
    items[1]=new_item("Two","");
    items[2]=new_item("Exit","");
    items[3]=(ITEM *)NULL;
    
    for(i=0;i<3;i++) {
	values[i]=i;   
	set_item_userptr(items[i],&values[i]);
    }
    
    menu=new_menu(items);
    
    post_menu(menu);
    
    for(;;) {
	ch=getch();
	switch(ch)
	{
	    case KEY_UP: {
		menu_driver(menu,REQ_UP_ITEM);
		break;
	    }
	
	    case KEY_DOWN: {
		menu_driver(menu,REQ_DOWN_ITEM);
		break;
	    }
	 
	    case 10 : {
		move(LINES-1,0);
		clrtoeol();
		
		curr_item=item_userptr(current_item(menu));
		
		mvprintw(LINES-1,0,"Пункт меню: %s Значение: %d",item_name(current_item(menu)),*curr_item);
		
		if(*curr_item==2) return 0;
		break;
	    }
	    case 'q': return 0;				
	}
    }
    
    endwin();
    return 0;
}
