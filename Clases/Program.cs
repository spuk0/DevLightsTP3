// See https://aka.ms/new-console-template for more information
using Resolucion3.Clases;



    Alumno alumno = new Alumno(40212221, "Javier", "Frias", 1997);
    Alumno alumno2 = new Alumno(40212221, "Javier Antonio", "Frias", 2022);

    Matrices matriz = new Matrices();
    MatrizJuego juego = new MatrizJuego();

    //Voy a crear una lista para agregar a los alumnos creados.
    List<Alumno> alumnos = new List<Alumno>();
    alumnos.Add(alumno);
    alumnos.Add(alumno2);

    //Instancio una clase GrupoPersonas que recibe en el constructor una lista de personas.
    GrupoPersonas personas = new GrupoPersonas(alumnos);

    //Lista de compras
    ProductoMercado producto = new ProductoMercado("Arroz");
    ProductoMercado producto2 = new ProductoMercado("Hamburguesa");

    AppSuperMercado mercadona = new AppSuperMercado(producto);


    int opcion = 0;

    //menu
    while (opcion != 9)
    {
        int numero = 0;
        Console.WriteLine("*************************************************************************************************" +
            "\nSeleccione el numero del ejercicio:\n" +
            "\n[1]> Dado que se tiene almacenado en una lista, los resultados de los últimos 10\r\nexámenes de un alumno, calcular su promedio y mostrar por pantalla las 10\r\nnotas de los exámenes y el promedio resultante.\n" +
            "\n[2]> Dada las edades de 20 personas guardadas en una lista, imprimir por\r\npantalla cuántos son mayores de edad y cuántos no.\n" +
            "\n[3]> Dado una lista de nombres de estudiantes, imprimir el que tenga más letras, y\r\nel que tenga menos letras de todos.\n" +
            "\n[4]> Crear una variable para guardar los nombres de elementos para una “lista de\r\nsupermercado”. Solicitar al usuario que ingrese el nombre de un elemento\r\nque va a comprar en el super y verificar que el elemento esté en la lista. Si no\r\nestá, agregarlo e indicar que no estaba. Si está, quitarlo de la lista, y avisar\r\nque sí estaba. Al finalizar mostrar por pantalla los elementos que no compró y\r\nlos que compró, pero no estaban en la lista. Si se quiere, mostrar también\r\ntodos los elementos que el usuario compró. Para salir el usuario debe\r\ningresar “fin”.\n" +
            "\n[5]> Crear una matriz de 5 x 5. Almacenar una ‘I’ en lugares impares y una ‘P’ en\r\nlugares pares. Imprimir la matriz por pantalla.\n" +
            "\n[6]> Se tiene una matriz de 5x7, donde 5 representa la semana de un mes y 7 los\r\ndías de la semana. La estructura es para registrar la temperatura diaria de\r\nuna cabina de pago, estos oscilan entre los 7 y 38 grados. Deberá llenar la\r\nmatriz de forma aleatoria para el mes de mayo donde el primer día inicia en\r\nlunes y el último (31) se ubica en el miércoles (la matriz puede ser inicializada\r\ncon valores aleatorios desde el principio del programa, no es necesario pedir\r\nlos valores al usuario para cada posición). Se nos pide hacer lo siguiente:\r\na. Obtener la temperatura más alta y baja de la semana y que día se\r\nprodujo (lunes, martes, etc.)\r\nb. Promedio de temperatura de la semana.\r\nc. Temperatura más alta del mes y su día.\n" +
            "\n[7]> Almacenar en una matriz las tablas del 1 al 9, teniendo en cuenta que en la\r\nprimera fila y la primera columna se debe guardar los números (de 0 a 9),\r\nestando el cero en la primera posición (fila 0, columna 0). El resto de los lugares debe ser calculado usando los números que se dispone, por ejemplo,\r\nen la fila 1, calcular 1*1, 1*2, 1*3, etc. usando las posiciones del array o\r\narreglo. Al finalizar el cálculo, mostrar la matriz por pantalla\n" +
            "\n[8]> Crear una matriz de 10 x 10, y “esconder” varias ‘X’ en lugares aleatorios (la\r\ncantidad que el programador decida, pero no más de la mitad de los lugares\r\ndisponibles en la matriz). El usuario deberá ingresar el lugar donde cree que\r\nhay una X, ingresando la fila y la columna por separado. Informar si acertó o\r\nno por cada ingreso. Se debe pedir al usuario ingresar valores por tantas X\r\nque se haya guardado. El usuario tiene 3 intentos para fallar. Al finalizar (Ya\r\nsea porque se terminaron los 3 intentos, o el jugador acertó todas las X)\r\nimprimir por pantalla la matriz con sus correspondientes X, mostrando un *\r\ndonde no haya nada.\n" +
            "\n[9]> Salir\n\n*************************************************************************************************");
        opcion = int.Parse(Console.ReadLine());
        switch (opcion)
        {
            case 1:
                alumno.MostrarDatos();
                limpiarYMenu();
                break;
            case 2:
                personas.MostrarEdadesMayoresYMenores();
                limpiarYMenu();
                break;
            case 3:
                personas.MostrarNombreMasLargoYCorto();
                limpiarYMenu();
                break;
            case 4:
                mercadona.MostrarLista();
                mercadona.Comprar();
                mercadona.MostrarLista();
                limpiarYMenu();
                break;
            case 5:
                matriz.MostrarDatos();
                limpiarYMenu();
                break;
            case 6:
                matriz.temperaturaMayo();
                matriz.TempMasAlta();
                matriz.TempMasBaja();
                matriz.TempMasAltaSemana();
                Console.WriteLine("PROMEDIO DE TEMPERATURA MAS ALTA DE LA SEMANA: " + matriz.PromedioTemperaturasSemana());
                limpiarYMenu();
                break;
            case 7:
                matriz.MostrarTablaDeMultiplicar();
                limpiarYMenu();
                break;
            case 8:
                juego.Play();
                limpiarYMenu();
                break;
        }
    }

    //LimpiarYMenu
    static void limpiarYMenu()
    {
        Console.WriteLine("Presione UNA tecla para volver al menu");
        Console.ReadKey();
        Console.Clear();
    }

