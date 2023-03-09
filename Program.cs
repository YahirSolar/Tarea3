namespace Tarea3;
class Program {
    static void Main(string[] args) {
        bool MostrarMenu = true;
        while(MostrarMenu){
            MostrarMenu = Menu();
        }
    }
    public static bool Menu() {
        Console.Clear();
        Console.WriteLine("Seleccione una opcion");
        Console.WriteLine("1- Agregar automovil");
        Console.WriteLine("2- Eliminar Automovil");
        Console.WriteLine("3- Buscar automovil");
        Console.WriteLine("4- Mostrar inventario de concecionario");
        Console.WriteLine("5- Salir");
        Console.Write("Opcion: ");
        switch(Console.ReadLine()){
            case "1": Console.WriteLine("Seleccionaste 1");
            Console.ReadLine();
            return true;
            case "2": Console.WriteLine("Seleccionaste 2");
            Console.ReadLine();
            return true;
            case "3": Console.WriteLine("Seleccionaste 3");
            Console.ReadLine();
            return true;
            case "4": Console.WriteLine("Seleccionaste 4");
            Console.ReadLine();
            return true;
            case "5": Console.WriteLine("Seleccionaste 5");
            Console.Clear();
            return false;
        }
        return true;
    }
}