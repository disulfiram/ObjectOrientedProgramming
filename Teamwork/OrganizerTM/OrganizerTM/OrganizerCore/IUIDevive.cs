using System;

namespace OrganizerCore
{
    internal interface IUIDevive
    {
        // contains events for button pressing
        event EventHandler<AnyButtonPressedEventArgs> RaiseButtonOnePressedEvent;

        event EventHandler<AnyButtonPressedEventArgs> RaiseButtonTwoPressedEvent;

        event EventHandler<AnyButtonPressedEventArgs> RaiseButtonThreePressedEvent;

        event EventHandler<AnyButtonPressedEventArgs> RaiseButtonLeftPressedEvent;

        event EventHandler<AnyButtonPressedEventArgs> RaiseButtonRightPressedEvent;

        void GetCommand();
    }
}
