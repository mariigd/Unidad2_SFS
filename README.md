# EVALUACIÓN 2 TILINES

* Mariana Gómez
* Laura Villanueva
* Willian Cadena

  ## Manual de Usuario
Esta es una simulación de un Scape room, el objetivo es escapar Himalaya, para hacerlo deberas resolver acertijo, por cada acertijo que resuelvas correctamente recibiras un caracter de los 6 que tiene el código que deberar darle al guadian del Himlaya y poder escapar.

Antes de empezar deberás configurar el numero de acertijos que deseas resolver, dependiendo de esto se definirá la temperatura a la que se empezará el juego, además deberás definir la latitud y presión atmosferica en la que empezaras. 

![Image](https://github.com/LCami-Villanueva/Imagenes/blob/main/1.jpg)

La interfaz contará con los siguientes elementos de interacción:
* Indicador de Temperatura: Aquí podras observar que tanj alta o baja será la temperatura con la que empezarás el juego (Ten en cuenta, que al iniciar la experiencia, esta ira disminuyendo con el tiempo, además tanto la latitud como presión atmosferica, tienen un indicador  que te muestra que tan alto o baja estan cada variable)
* Botón subir Temperatura: Con este botón podrás subir la temperatura con la que iniciarás la experiencia. (Ten en cuenta que tanto latitud como presión atmosferica, tienen un boton similar que igual cumple la funcion de aumentar su respectiva variable)
* Botón bajar Temperatura: Con este botón podrás bajar la temperatura con la que iniciarás la experiencia. (Ten en cuenta que tanto latitud como presión atmosferica, tienen un boton similar que igual cumple la funcion de disminuir su respectiva variable)
* Indicador Numero de acertijos: Aquí podrás ver cuantos acertijos tendrás que resolver en la experiencia.

  ## Manual Desarrollador

* Config

"""

    Botones
    public Button TempMas;
    public Button TempMenos;

    public Button ALTmas;
    public Button ALTmenos;

    public Button PresMas;
    public Button PresMenos;

    public Button Comenzar;

    //Boton presionado
    private bool PresionadoTempMas = false;
    private bool PresionadoTempMenos = false;

    private bool PresionadoALTmas = false;
    private bool PresionadoALTmenos = false;

    private bool PresionadoPresMas = false;
    private bool PresionadoPresMenos = false;

    private bool PresionadoComenzar = false;

    //Variables
    public static int temperature = 20;
    int acertijos =  temperature;
    int altura = 0;
    int presion = 0;

    //Visualización de temperatura
    public Image TempIMG;
    public Sprite Frio;
    public Sprite Congelado;
    public Sprite Caliente;
    public Sprite Asado;
    public Sprite Normal;

    //Visualización de Altura
    public Image AltIMG;
    public Sprite Media;
    public Sprite Alta;
    public Sprite Baja;

    //Visualización de Presion
    public Image PresIMG;
    public Sprite PresB;
    public Sprite PresM;
    public Sprite PresA;

    public TextMeshProUGUI NumAcertijos;

Esta parte del código se encarga de declarar y definir las variables y elementos que se utilizarán 
para interactuar con la interfaz de usuario y para controlar el comportamiento del programa.

* Botones:

Primero, estamos diciendo qué botones tenemos en nuestra interfaz. Por ejemplo, mencionamos que tenemos botones para subir y 
bajar la temperatura (TempMas y TempMenos), para subir y bajar la altura (ALTmas y ALTmenos), para subir 
y bajar la presión (PresMas y PresMenos), y un botón para empezar (Comenzar).

* Botones Presionados:

Luego, estamos guardando si estos botones están siendo presionados o no. Si, por ejemplo, aprietas el botón 
TempMas, la variable PresionadoTempMas pasa a ser true, indicando que el botón se encuentra presionado. Lo mismo para los demás botones.

* Variables de Datos:

Aquí estamos guardando información importante. La variable temperature guarda la temperatura actual del juego o la aplicación. 
Acertijos, altura, y presion son otras variables que guardan información relacionada con el juego.

* Visualización de Temperatura:

Finalmente, mencionamos que tenemos imágenes para mostrar cómo está la temperatura. Por ejemplo, si la temperatura es de 10 grados, mostraremos 
una imagen de "Congelado". Si es de 20 grados, mostraremos una imagen de "Normal". Estas imágenes se muestran en la pantalla para que el jugador pueda ver la temperatura de manera visual.



    
    
