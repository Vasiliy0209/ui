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
    
    endwin();
    return 0;
}
