#include <ncurses.h>

int main(int argc, char *argv[])
{       WINDOW *my_win;

        initscr();                      /* Start curses mode            */

        my_win = newwin(3,3,3,3);
        box(my_win,0,0);          /* 0, 0 gives default characters 
                                         * for the vertical and horizontal
                                         * lines                        */
        wrefresh(my_win);            /* Show that box                */

	endwin();
        return 0;
}