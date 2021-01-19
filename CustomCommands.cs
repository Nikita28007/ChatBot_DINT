using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ChatBot_DINT
{
    class CustomCommands
    {
        public static readonly RoutedUICommand newConversation = new RoutedUICommand
            (
                "conversacion nuevo",
                "New conversation",
                typeof(CustomCommands),
            new InputGestureCollection()
            {
                new KeyGesture(Key.N,ModifierKeys.Control)
            }
            
            );

        public static readonly RoutedUICommand saveConversation = new RoutedUICommand
           (
               "Guardar Conversación",
               "Save conversation",
               typeof(CustomCommands),
           new InputGestureCollection()
           {
                new KeyGesture(Key.G,ModifierKeys.Control)
           }

           );

        public static readonly RoutedUICommand exit = new RoutedUICommand
          (
              "Salir",
              "exit",
              typeof(CustomCommands),
          new InputGestureCollection()
          {
                new KeyGesture(Key.S,ModifierKeys.Control)
          }

          );

        public static readonly RoutedUICommand config = new RoutedUICommand
        (
            "Configuración",
            "configuration",
            typeof(CustomCommands),
        new InputGestureCollection()
        {
                new KeyGesture(Key.C,ModifierKeys.Control)
        }

        );

        public static readonly RoutedUICommand connection = new RoutedUICommand
      (
          "Comprobar Conexión",
          "Check connection",
          typeof(CustomCommands),
      new InputGestureCollection()
      {
                new KeyGesture(Key.O,ModifierKeys.Control)
      }

      );

    }
}
