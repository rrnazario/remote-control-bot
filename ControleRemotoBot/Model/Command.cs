using System;

namespace ControleRemotoBot.Model
{
    public class Command
    {
        private string _alias;
        public string Alias 
        { 
            get => string.IsNullOrEmpty(_alias) ? Name : _alias; 
            set => _alias = value; 
        }
        public string Name { get; set; }
        public Action CommandAction { get; set; }

        public override string ToString() => $"{Name}";
        public string ToSave() => $"{Name}|{Alias}";

        public Command() { }

        public Command(string cmd)
        {
            var split = cmd.Split("|");
            
            Name = split[0];
            Alias = split[1];
            CommandAction = Constants.AvailableCommands[Name];
        }
    }
}
