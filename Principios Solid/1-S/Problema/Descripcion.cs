
//Single Responsability Principal
//Principio de Responsabilidad Única

//Descripcion del Principo:
//una clase tiene que tener unicamente una responsabilidad,
//es decir: "cualquier responsabilidad que no sea la de dicho clase,
//se hara externamente utilizando una interfaz"

//Descripcion del problema:
//El metodo SaveOrder tiene 4 responsabilidades
//1.- Insertar la orden
//2.- Crear el invoice
//3.- Enviar el invoice por email
//4.- Escribir escribir el log en caso de que salga bien o un error en caso de que salga mal
//Estas responsabilidades se hacen internamente, y no cumplen con el principio 

//Solucion:
//Cada vez que haya algun cambio en una metodo se tendra que cambiar la clase,
//para evitar esto hay que crear interfaces encargadas de realizar una unica tarea
//que cumpla con lo que se necesite.