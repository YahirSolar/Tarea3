namespace Tarea3;

class Automovil {
    public string placa;
    public string marca;
    public string modelo;
    public int km = 0;
    public double precio = 0.0;

    public Automovil(string placa, string marca, string modelo, int km, double precio ){
        this.placa = placa;
        this.marca = marca;
        this.modelo = modelo;
        this.km = km;
        this.precio = precio;
    }

    public override string ToString() {
        return $"Id: {placa}" + $"Marca: {marca}" + $"Modelo: {modelo}" + $"KM: {km}" + $"Precio: {precio}";
    }
}