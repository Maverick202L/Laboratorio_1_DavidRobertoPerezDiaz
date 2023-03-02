using LABORATORIO_1_DavidRobertoPerezDiaz.Entidades;
using LABORATORIO_1_DavidRobertoPerezDiaz.Negocio;

Persona pers = new Persona();
ClsPersona  clsper = new ClsPersona();

Console.WriteLine("====================================================================================");
Console.WriteLine("Bienvenido Ingeniero a mi primer procesador de datos en C#, espero sea de su agrado ");
Console.WriteLine("====================================================================================");

Console.WriteLine("\nIngrese su nombre");
String VariableNombre = Console.ReadLine();

Console.WriteLine("\nIngrese su edad");
String VariableEdad = Console.ReadLine();

Console.WriteLine("\n¿A que sexo pertenece?");
String VariableSex = Console.ReadLine();

Console.WriteLine("\n ¿Cuanto Pesa en Kilogramos?");
String VariablePeso = Console.ReadLine();

Console.WriteLine("\n ¿Cuanto es su altura en centimetros?");
String Variablealt = Console.ReadLine();

int Edadconvert = Convert.ToInt32(VariableEdad);
int altconvert = Convert.ToInt32(Variablealt);
int Pesconvert = Convert.ToInt32(VariablePeso);

pers.Nombre = VariableNombre;
pers.Edad = Edadconvert;
pers.Sexo = VariableSex;
pers.Altura = altconvert;
pers.Peso = Pesconvert;


string resultado = clsper.ObtenerNombrePersona(pers);
string resultadoEdad = clsper.MayordeEdad(pers);
string resultadoSex = clsper.Comprobar_Sex(pers);
string resultadoProm = clsper.Calcular_IMC(pers);
Console.WriteLine(resultado);
Console.WriteLine(resultadoEdad);  
Console.WriteLine(resultadoSex);
Console.WriteLine(resultadoProm);

















