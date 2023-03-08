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
        if(actual < limite){
            Autos.Add(auto);
            actual += 1;
        }else{
            Console.WriteLine("No hay mas espacio en la Concesionaria");
        }
    }
    public void MostrarAuto(Automovil auto) {
        if(auto != null) {
            foreach(Automovil item in Autos) {
                if(item == auto){
                    Console.WriteLine(item);
                    return; 
                }
            }
        Console.WriteLine("El auto que buscas no está en la Concesionario");
        }
    }
    public void EliminarAuto(Automovil auto) {
        if(actual != 0){
            foreach(Automovil item in Autos){
                if(item == auto){
                    Autos.Remove(item);
                    actual -= 1;
                    return; 
                }
            }
        }else{
            Console.WriteLine("No hay autos que eliminar de la Concesionaria");
        }
    }
    public void MostrarAutos() {
        foreach(Automovil item in Autos){
            Console.WriteLine(item);
        }
    }
    public void VaciarConcesionario(Automovil auto) {
        Autos.Clear();
        Console.WriteLine("La Concesionaria está vacia");
    }
}