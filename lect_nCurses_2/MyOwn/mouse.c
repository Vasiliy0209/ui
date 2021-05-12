# include <ncurses.h>

int main(int argc, char *argv[])
{
    MEVENT event;
    initscr();
    noecho();
    
    mousemask(ALL_MOUSE_EVENTS,NULL);
    keypad(stdscr,TRUE);
    for(;;) {
	//printw("[%d] KEY_MOUSE=[%d]\n",getch(),KEY_MOUSE);
	if(getch()==KEY_MOUSE && getmouse(&event)==OK)
	{
	    printw("Mouse happened x=%d y=%d z=%d\n",event.x,event.y,event.z);
	    /*if(event.bstate & BUTTON1_PRESSED)
		printw("Left\n");
	    if(event.bstate & BUTTON2_PRESSED)
		printw("Right\n");*/
		/*if(event.bstate & BUTTON1_PRESSED)
		        printw("Left Button Pressed");*/
	}
	else
	    printw("BAD MOUSE\n");	
    }    
    endwin();
    return 0;
}
