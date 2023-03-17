namespace Tarea3;

    class Menu{

        Concesionaria concesionaria = new Concesionaria(3);
        public bool ShowMenu() {
        Console.Clear();
        Console.WriteLine("Seleccione una opcion");
        Console.WriteLine("1- Agregar automovil");
        Console.WriteLine("2- Eliminar Automovil");
        Console.WriteLine("3- Buscar automovil");
        Console.WriteLine("4- Mostrar inventario de concecionario");
        Console.WriteLine("5- Vaciar el concecionario");
        Console.WriteLine("6- Salir");
        Console.Write("Opcion: ");
        switch(Console.ReadLine()){
            case "1": Console.WriteLine("Seleccionaste 1");
            AgregarAutomovil();
            Console.ReadLine();
            return true;
            case "2": Console.WriteLine("Seleccionaste 2");
            EliminarAutoMovil();
            Console.ReadLine();
            return true;
            case "3": Console.WriteLine("Seleccionaste 3");
            BuscarAutomovil();
            Console.ReadLine();
            return true;
            case "4": Console.WriteLine("Seleccionaste 4");
            MostrarInventario();
            Console.ReadLine();
            return true;
            case "5": Console.WriteLine("Seleccionaste 5");
            VaciarConcesionario();
            Console.ReadLine();
            return true;
            case "6": Console.WriteLine("Seleccionaste 6 buelva pronto");
            Console.Clear();
            return false;
        }
        return true;
    }

    public void AgregarAutomovil() {

        Console.Clear(); 
        Console.WriteLine("creando nuevo automovil");

        Console.Write("Placa: ");
        string? id = Console.ReadLine();
        Console.Write("Marca: ");
        string? marca = Console.ReadLine();
        Console.Write("Modelo: ");
        string? modelo = Console.ReadLine();
        Console.Write("Km: ");
        string? km = Console.ReadLine();
        Console.Write("Precio: ");
        string? precio = Console.ReadLine();

        Automovil nuevo = new Automovil(id,marca,modelo,Convert.ToInt32(km),Convert.ToDouble(precio));
        concesionaria.AgregarAuto(nuevo);
    }

    public void EliminarAutoMovil() {
        Console.Clear();
        Console.Write("Dame la placa del carro a eliminar: ");
        string? placa = Console.ReadLine();
        concesionaria.EliminarAuto(placa);
    }

    public void BuscarAutomovil() {
        Console.Clear();
        Console.Write("Dame la placa del carro a buscar: ");
        string? placa = Console.ReadLine();
        concesionaria.MostrarAuto(placa);
    }

    public void MostrarInventario() {
        Console.Clear();
        Console.WriteLine("Autos de la Concecionaria SamuPelonSA");
        concesionaria.MostrarAutos();
    }

    public void VaciarConcesionario(){
        Console.Clear();
        concesionaria.VaciarConcesionario();
    }
}