//Liskov substitution Principle
//Principio de Substitucion de Liskov

//Descripcion:
//Las clases derivadas deben poder sustituirse con sus clases base
//Esta clase trata de cumplir con diferentes escenarios
 
//Problema:
//Se utiliza una clase abstracta para implementarla en diferentes subclases,
//estas subclases contienen metodos que no necesitan,
//los vehiculos aereos no pueden utilizar los mismos metodos que los vehiculos terrestres

//Solucion:
//Implementar varias interfaces especificas para cada metodo e implementarlas por separado,
//Permitiendo el uso exclusivo de metodos relacionados a la propia clase y evitando el uso
//indebido de otros metodos.