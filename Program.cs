//USO DE TRY Y CATCH
using System;

try
{
    Console.WriteLine("\n **1. CALCULA EL MAYOR DE TRES NÚMEROS**");
    Console.WriteLine("--------------------------");

    int num1, num2, num3, mayor;

    Console.WriteLine("Introduzca el primer número:");
    num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Introduzca el segundo número:");
    num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Introduzca el tercer número:");
    num3 = Convert.ToInt32(Console.ReadLine());

    mayor = num1;
    if (num2 > mayor)
    {
        mayor = num2;
    }
    if (num3 > mayor)
    {
        mayor = num3;
    }

    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("El mayor de los tres números es: " + mayor);
    Console.ResetColor();
}
catch (FormatException)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Error: Ingrese solo números enteros.");
    Console.ResetColor();
}
catch (OverflowException)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Error: El número ingresado es demasiado grande.");
    Console.ResetColor();
}
catch (Exception ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Error: {ex.Message}");
    Console.ResetColor();
}

try
{
    Console.WriteLine("\n**2. INGRESO AL CLUB DE AMIGOS**");
    Console.WriteLine("--------------------------");

    Console.WriteLine("Introduzca su edad: ");
    int edad = Convert.ToInt32(Console.ReadLine());

    if (edad >= 18)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("** ¡AL CLUB DE AMIGOS, DISFRUTA DE NUESTROS EVENTOS!**");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("**ACCESO DENEGADO AL CLUB DE AMIGOS, DISFRUTA TU NIÑEZ. REGRESA CUANDO TENGAS 18 AÑOS COMO MÍNIMO**");
        Console.ResetColor();
    }
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("** ¡AL CLUB DE AMIGOS, DISFRUTA DE NUESTROS EVENTOS!**");
    Console.ResetColor();

    Console.WriteLine("\n **3. CALCULA EL PRECIO CON DESCUENTO EN LA COMPRA MAYOR A Q.100.00**");
    Console.WriteLine("--------------------------");
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("**Ingrese el precio original del producto:**");
    Console.ResetColor();

    double precioOriginal = Convert.ToDouble(Console.ReadLine());


    if (precioOriginal > 100)
    {
        double descuento = precioOriginal * 0.10;
        double precioFinal = precioOriginal - descuento;
        Console.WriteLine($"El precio final con descuento es: Q{precioFinal}");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"El precio final es: Q{precioOriginal}");
        Console.ResetColor();
    }
}
catch (FormatException)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Error: Ingrese solo números enteros.");
    Console.ResetColor();
}
catch (OverflowException)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Error: El número ingresado es demasiado grande.");
    Console.ResetColor();
}
catch (Exception ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Error: {ex.Message}");
    Console.ResetColor();
}

Console.WriteLine("\n **4. USUARIO Y CONTRASEÑA**");
Console.WriteLine("--------------------------");

string usuarioValido = "usuario";
string contrasenaValida = "contraseña";
string nuevoUsuario = "nuevoUsuario";
string nuevaContrasena = "nuevaContrasena";

string nombreUsuario = "";
string contrasena = "";

try
{
    Console.WriteLine("Ingrese su nombre de usuario:");
    nombreUsuario = Console.ReadLine();

    Console.WriteLine("Ingrese su contraseña:");
    contrasena = Console.ReadLine();

    if (nombreUsuario != null && contrasena != null)
    {
        bool accesoPermitido = (nombreUsuario == usuarioValido && contrasena == contrasenaValida) ||
                               (nombreUsuario == nuevoUsuario && contrasena == nuevaContrasena);

        if (accesoPermitido)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("ACCESO PERMITIDO");
            Console.ResetColor();
        }
        else
        {
            if (nombreUsuario != usuarioValido && nombreUsuario != nuevoUsuario)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("ACCESO DENEGADO. Usuario no encontrado.");
                Console.ResetColor();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("ACCESO DENAGADO. Contraseña incorrecta.");
                Console.ResetColor();


            }
        }
    }
    else
    {

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("ERROR: El nombre de usuario o la contraseña son nulos.");
        Console.ResetColor();

    }
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

{
    try
    {
        int numero;
        Console.WriteLine("\n **5. NÚMERO PAR O IMPAR**");
        Console.WriteLine("--------------------------");

        Console.WriteLine("Ingrese un número:");
        numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("El número {0} es par.", numero);
            Console.ResetColor();

        }
        else
        {

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("El número {0} es impar.", numero);
            Console.ResetColor();
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Error: Ingrese un número válido.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Error: El número ingresado es demasiado grande.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.ResetColor();
    }
}
{
    double montoPrestamo;
    int edad;

    try
    {
        Console.WriteLine("\n **6. MENSAJE DE APROBACIÓN O RECHAZO DE PRÉSTAMO**");
        Console.WriteLine("--------------------------");
        Console.WriteLine("Ingrese el monto del préstamo:");
        montoPrestamo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese su edad:");
        edad = Convert.ToInt32(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("Error: Ingrese valores numéricos válidos.");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.ResetColor();
        return;
    }

    bool aprobado = montoPrestamo < 5000 || edad > 60;

    if (aprobado)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("¡Felicidades! Su préstamo ha sido aprobado.");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Lo sentimos, su préstamo ha sido rechazado.");
        Console.ResetColor();
    }
}
{
    Console.WriteLine("\n **7.CALCULAR EL ÁREA DE UNA FIGURA GEOMÉTRICA:**");
    Console.WriteLine("------------------------------------------");

    try
    {
        Console.WriteLine("Ingrese el tipo de figura geométrica (triángulo, cuadrado o círculo):");
        string figura = Console.ReadLine().ToLower();

        double area = 0;

        switch (figura)
        {
            case "triángulo":
                Console.WriteLine("Ingrese la base del triángulo:");
                double baseTriangulo = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese la altura del triángulo:");
                double alturaTriangulo = Convert.ToDouble(Console.ReadLine());
                area = (baseTriangulo * alturaTriangulo) / 2;
                break;
            case "cuadrado":
                Console.WriteLine("Ingrese el lado del cuadrado:");
                double ladoCuadrado = Convert.ToDouble(Console.ReadLine());
                area = ladoCuadrado * ladoCuadrado;
                break;
            case "círculo":
                Console.WriteLine("Ingrese el radio del círculo:");
                double radioCirculo = Convert.ToDouble(Console.ReadLine());
                area = Math.PI * radioCirculo * radioCirculo;
                break;
            default:

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Figura no válida.");
                Console.ResetColor();

                return;
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"El área de la figura {figura} es: {area}");
        Console.ResetColor();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }

    //USO DE SWITCH
    {
        Console.WriteLine("\n **1.CONVERTIR NÚMEROS EN LETRA A NÚMERO:**");
        Console.WriteLine("--------------------------");
        Console.WriteLine("Convertir un Número de Letra a Número");
        Console.WriteLine("--------------------------------------");

        Console.WriteLine("Ingrese un número del 1 al 5 en letra:");
#pragma warning disable CS8602
        string numeroLetra = Convert.ToString(value: Console.ReadLine().ToLower());

        int numeroDigito;

        switch (numeroLetra)
        {
            case "uno":
                numeroDigito = 1;
                break;
            case "dos":
                numeroDigito = 2;
                break;
            case "tres":
                numeroDigito = 3;
                break;
            case "cuatro":
                numeroDigito = 4;
                break;
            case "cinco":
                numeroDigito = 5;
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Número no válido.");
                Console.ResetColor();

                return;
        }
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine($"El número en dígito es: {numeroDigito}");
        Console.ResetColor();
    }
    {
        Console.WriteLine("\n **2.MOSTRAR EL DÍA DE LA SEMANA A PARTIR DE UN NÚMERO:**");
        Console.WriteLine("--------------------------");

        Console.WriteLine("Ingrese un número del 1 al 7:");
        int numeroDia = Convert.ToInt32(Console.ReadLine());

        string diaSemana;

        switch (numeroDia)
        {
            case 1:
                diaSemana = "Lunes";
                break;
            case 2:
                diaSemana = "Martes";
                break;
            case 3:
                diaSemana = "Miércoles";
                break;
            case 4:
                diaSemana = "Jueves";
                break;
            case 5:
                diaSemana = "Viernes";
                break;
            case 6:
                diaSemana = "Sábado";
                break;
            case 7:
                diaSemana = "Domingo";
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Número no válido.");
                Console.ResetColor();
                return;
        }

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"El día de la semana correspondiente al número {numeroDia} es: {diaSemana}");
        Console.ResetColor();
    }
    {
        Console.WriteLine("\n **3.CALCULAR EL IMPORTE A PAGAR POR UN SERVICIO **");
        Console.WriteLine("--------------------------");

        Console.WriteLine("Ingrese el tipo de servicio (lavado de auto, cambio de aceite, revisión mecánica):");
        string tipoServicio = Console.ReadLine().ToLower();

        double importePagar;

        switch (tipoServicio)
        {
            case "lavado de auto":
                importePagar = 50.00;
                break;
            case "cambio de aceite":
                importePagar = 100.00;
                break;
            case "revisión mecánica":
                importePagar = 150.00;
                break;
            default:
                Console.WriteLine("Tipo de servicio no válido.");
                return;
        }

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine($"El importe a pagar por el servicio de {tipoServicio} es: {importePagar:C}");
        Console.ResetColor();
    }
    Console.WriteLine("\n** 4.MOSTRAR UN MENSAJE DE BIENVENIDA EN DIFERENTE IDIOMA**");
    Console.WriteLine("-------------------------------------------------------");

    Console.WriteLine("Seleccione su idioma de preferencia (español, inglés, francés):");
    string idioma = Console.ReadLine().ToLower();

    string mensajeBienvenida;

    switch (idioma)
    {
        case "español":
            mensajeBienvenida = "¡Bienvenido!";
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(mensajeBienvenida);
            Console.ResetColor();

            break;
        case "inglés":
            mensajeBienvenida = "Welcome!";
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(mensajeBienvenida);
            Console.ResetColor();

            break;
        case "francés":
            mensajeBienvenida = "Bienvenue!";
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(mensajeBienvenida);
            Console.ResetColor();

            break;
        default:
            Console.WriteLine("Idioma no válido.");
            break;
    }
    Console.WriteLine("\n **5.EVALUAR LA CALIFICACIÓN DE UN EXAMEN**");
    Console.WriteLine("-------------------------------------");

    Console.WriteLine("Ingrese la calificación del examen:");
    string inputCalificacion = Console.ReadLine();

    if (int.TryParse(inputCalificacion, out int calificacion))
    {
        string desempenio;

        if (calificacion >= 90 && calificacion <= 100)
        {
            desempenio = "Sobresaliente";
        }
        else if (calificacion >= 80 && calificacion <= 89)
        {
            desempenio = "Notable";
        }
        else if (calificacion >= 70 && calificacion <= 79)
        {
            desempenio = "Aprobatoria";
        }
        else if (calificacion >= 60 && calificacion <= 69)
        {
            desempenio = "No aprobatoria";
        }
        else if (calificacion >= 0 && calificacion < 60)
        {
            desempenio = "Reprobatoria";
        }
        else
        {
            desempenio = "Calificación no válida";
        }

        Console.WriteLine($"Desempeño: {desempenio}");
    }
    else
    {
        Console.WriteLine("Error: La calificación ingresada no es un número entero.");
    }
}
