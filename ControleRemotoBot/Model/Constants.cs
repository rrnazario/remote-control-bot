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
                "Espaço",
                () => inputSimulator.Keyboard.KeyDown(VirtualKeyCode.SPACE)
            },

            {
                "Pra cima",
                () => inputSimulator.Keyboard.KeyDown(VirtualKeyCode.UP)
            },

            {
                "Pra baixo",
                () => inputSimulator.Keyboard.KeyDown(VirtualKeyCode.DOWN)
            },
            {
                "Esquerda",
                () => inputSimulator.Keyboard.KeyDown(VirtualKeyCode.LEFT)
            },
            {
                "Direita",
                () => inputSimulator.Keyboard.KeyDown(VirtualKeyCode.RIGHT)
            },
            {
                "Tab",
                () => inputSimulator.Keyboard.KeyDown(VirtualKeyCode.TAB)
            },
            {
                "Fechar",
                () => inputSimulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.MENU, VirtualKeyCode.F4)
            },
            {
                "Trocar janela",
                () => inputSimulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.MENU, VirtualKeyCode.TAB)
            },
            {
                "Enter",
                () => inputSimulator.Keyboard.KeyDown(VirtualKeyCode.RETURN)
            },
        };
    }
}
