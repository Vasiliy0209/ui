# include <ncurses.h>

int main(int argc, char *argv[])
{
    WINDOW *mywin;
    
    initscr();
    cbreak();
    start_color();
    
    mywin=newwin(10,20,10,20);
    
    init_pair(1,COLOR_WHITE,COLOR_RED);
    wattron(mywin,COLOR_PAIR(1));
    box(mywin,0,0);
    wprintw(mywin,"\nHello");
    wrefresh(mywin);
    //refresh();
    endwin();    
    return 0;
}

