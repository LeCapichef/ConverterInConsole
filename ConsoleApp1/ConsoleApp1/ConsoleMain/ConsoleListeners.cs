using System.ComponentModel;
using System.Reflection.Metadata;

namespace ConsoleApp1
{
    public static class ConsoleListener
    {
        public static event ConsoleMouseEvent MouseEvent;

        public static event ConsoleKeyEvent KeyEvent;

        public static event ConsoleWindowBufferSizeEvent WindowBufferSizeEvent;

        private static bool Run = false;


        public static void Start()
        {
            if (!Run)
            {
                Run = true;
                IntPtr handleIn = NativeMethods.GetStdHandle(NativeMethods.STD_INPUT_HANDLE);
                new Thread(() =>
                {
                    uint mode = 0;
                    if (!(NativeMethods.GetConsoleMode(handleIn, ref mode))) { throw new Win32Exception(); }

                    mode |= NativeMethods.ENABLE_MOUSE_INPUT;
                    mode &= ~NativeMethods.ENABLE_QUICK_EDIT_MODE;
                    mode |= NativeMethods.ENABLE_EXTENDED_FLAGS;

                    if (!(NativeMethods.SetConsoleMode(handleIn, mode))) { throw new Win32Exception(); }

                    while (true)
                    {
                        uint numRead = 0;
                        NativeMethods.INPUT_RECORD[] record = new NativeMethods.INPUT_RECORD[1];
                        record[0] = new NativeMethods.INPUT_RECORD();
                        NativeMethods.ReadConsoleInput(handleIn, record, 1, ref numRead);
                        if (Run)
                            switch (record[0].EventType)
                            {
                                case NativeMethods.INPUT_RECORD.MOUSE_EVENT:
                                    MouseEvent?.Invoke(record[0].MouseEvent);
                                    break;
                                case NativeMethods.INPUT_RECORD.KEY_EVENT:
                                    KeyEvent?.Invoke(record[0].KeyEvent);
                                    break;
                                case NativeMethods.INPUT_RECORD.WINDOW_BUFFER_SIZE_EVENT:
                                    WindowBufferSizeEvent?.Invoke(record[0].WindowBufferSizeEvent);
                                    break;
                            }
                        else
                        {
                            uint numWritten = 0;
                            NativeMethods.WriteConsoleInput(handleIn, record, 1, ref numWritten);
                            return;
                        }
                    }
                }).Start();
            }
        }

        public static void Stop() => Run = false;

        public static bool IsRunning() { return Run; }

        public delegate void ConsoleMouseEvent(NativeMethods.MOUSE_EVENT_RECORD r);

        public delegate void ConsoleKeyEvent(NativeMethods.KEY_EVENT_RECORD r);

        public delegate void ConsoleWindowBufferSizeEvent(NativeMethods.WINDOW_BUFFER_SIZE_RECORD r);

    }
}
