namespace Tarea3;

class Concesionaria {
    public List<Automovil> Autos;
    public int limite;
    public int actual;

    public Concesionaria(int limite) {
        Autos = new List<Automovil>();
        this.limite = limite;
        this.actual = 0;
    }
    public void AgregarAuto(Automovil auto) {
        if(auto != null && actual < limite) {
            Automovil? autoEncontrado = Autos.Find((autoL) => autoL.placa == auto.placa);
            if(autoEncontrado == null) {
                Autos.Add(auto);
                actual += 1;
                Console.WriteLine("Automovil agregado exitosamente");
            }else {
                Console.WriteLine("No se agrego el automovil");
            }
        }else {
            Console.WriteLine("No hay mas espacio en la Concesionaria");
        }
    }
    public void MostrarAuto(string? placa) {

        Automovil? autoEncontrado = Autos.Find((autoL) => autoL.placa == placa);
        if(autoEncontrado != null) {
            Console.WriteLine("El Auto es:");
            Console.WriteLine(autoEncontrado.ToString());
        }else {
            Console.WriteLine("El automovil no se encontro");
        }
    }
    public void EliminarAuto(string? placa) {
        if(placa != "" && actual != 0) {
            Automovil? autoEncontrado = Autos.Find((autoL) => autoL.placa == placa);
            if(autoEncontrado != null) {
                Autos.Remove(autoEncontrado);
                actual -= 1;
                Console.WriteLine("Automovil eliminado exitosamente");
            }else {
                Console.WriteLine("No se elimino el automovil");
            }  
        }else {
            Console.WriteLine("No hay autos que eliminar de la Concesionaria");
        }
    }
    public void MostrarAutos() {
        foreach(Automovil item in Autos) {
            Console.WriteLine(" Automovil:\n" + item);
        }
    }
    public void VaciarConcesionario() {
        Autos.Clear();
        Console.WriteLine("La Concesionaria está vacia el samu pelon se los robo");
    }
}