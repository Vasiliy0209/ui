#include <ncurses.h>
#include <menu.h>

int main() {
    initscr();
    keypad(stdscr,TRUE);
    start_color();
    WINDOW *w=newwin(20,15,1,1);
    WINDOW *dw = derwin(w,18,13,1,1);
    
    //box(w,0,0);
    init_pair(1,COLOR_WHITE,COLOR_RED);
    wattron(w,COLOR_PAIR(1));
    
    box(w,0,0);
    wrefresh(w);
    wattron(dw,COLOR_PAIR(1));
    
    wprintw(dw,"Hi");
    wgetch(dw);
    wbkgd(dw,COLOR_PAIR(1));
    wclear(dw);
    wgetch(dw);
    wrefresh(dw);
    wgetch(dw);
    wprintw(dw,"Hello  ");
    wrefresh(dw);
    wgetch(w);
    endwin();
    return 0;
}
