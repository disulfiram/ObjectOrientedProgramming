using System;

namespace OrganizerCore
{
    internal class Keyboard : IUIDevive
    {
        public event EventHandler<AnyButtonPressedEventArgs> RaiseButtonOnePressedEvent; // 1
        
        public event EventHandler<AnyButtonPressedEventArgs> RaiseButtonTwoPressedEvent; // 2
        
        public event EventHandler<AnyButtonPressedEventArgs> RaiseButtonThreePressedEvent; // 3
        
        public event EventHandler<AnyButtonPressedEventArgs> RaiseButtonLeftPressedEvent; // <- Left Arrow
        
        public event EventHandler<AnyButtonPressedEventArgs> RaiseButtonRightPressedEvent; // -> Right Arrow

        public void GetCommand()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyPressed = Console.ReadKey();
                if (keyPressed.Key == ConsoleKey.D1)
                {
                    if (this.RaiseButtonOnePressedEvent != null)
                    {
                        this.RaiseButtonOnePressedEvent(this, new AnyButtonPressedEventArgs());                                                
                    }

                    if (this.RaiseButtonTwoPressedEvent != null)
                    {
                        this.RaiseButtonTwoPressedEvent(this, new AnyButtonPressedEventArgs());
                    }

                    if (this.RaiseButtonThreePressedEvent != null)
                    {
                        this.RaiseButtonThreePressedEvent(this, new AnyButtonPressedEventArgs());
                    }

                    if (this.RaiseButtonLeftPressedEvent != null)
                    {
                        this.RaiseButtonLeftPressedEvent(this, new AnyButtonPressedEventArgs());
                    }

                    if (this.RaiseButtonRightPressedEvent != null)
                    {
                        this.RaiseButtonRightPressedEvent(this, new AnyButtonPressedEventArgs());
                    }
                }
            }
        }

        // handle events for button pression
    }
}
