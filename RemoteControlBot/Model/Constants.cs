using System;
using System.Collections.Generic;
using WindowsInput;
using WindowsInput.Native;

namespace ControleRemotoBot.Model
{
    public class Constants
    {
        public static readonly InputSimulator inputSimulator = new();
        public static Dictionary<string, Action> AvailableCommands = new()
        {
            {
                "Space",
                () => inputSimulator.Keyboard.KeyDown(VirtualKeyCode.SPACE)
            },

            {
                "Up",
                () => inputSimulator.Keyboard.KeyDown(VirtualKeyCode.UP)
            },

            {
                "Down",
                () => inputSimulator.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            },
            {
                "Left",
                () => inputSimulator.Keyboard.KeyDown(VirtualKeyCode.LEFT)
            },
            {
                "Right",
                () => inputSimulator.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            },
            {
                "Tab",
                () => inputSimulator.Keyboard.KeyDown(VirtualKeyCode.TAB)
            },
            {
                "Alt+F4",
                () => inputSimulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.MENU, VirtualKeyCode.F4)
            },
            {
                "Change Window",
                () => inputSimulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.MENU, VirtualKeyCode.TAB)
            },
            {
                "Enter",
                () => inputSimulator.Keyboard.KeyDown(VirtualKeyCode.RETURN)
            },
        };
    }
}
