using ejerc1;

Delfin d1 = new Delfin();
d1.Nombre = "Jeriko";
Delfin d2 = new Delfin();
d2.Nombre = "Adriano";
Orca o1 = new Orca();
o1.Nombre = "Marlon";

Acuario a1 = new Acuario();
a1.direccion = "Jr. Va 1960 (Si lees esto esa direccion es mi casa el (Va) es solo las dos primeras letras del nombre de la calle)";
a1.Delfin1 = d1;
a1.Delfin2 = d2;
a1.Orca1 = o1;
Console.WriteLine(a1.direccion);
a1.ListaNombre();