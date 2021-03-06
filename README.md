# Práctica 2: Introducción a los scripts en Unity

- Autor: Adal Díaz Fariña
- Contacto: alu0101112251@ull.edu.es

**1 Crear una escena simple sobre la que probar diferentes configuraciones de objetos físicos en Unity. La escena debe tener un plano a modo de suelo, una esfera y un cubo.**

&nbsp;&nbsp;&nbsp;&nbsp;**a. Ninguno de los objetos será físico.**

&nbsp;&nbsp;&nbsp;&nbsp;Al ningún objeto ser físico como podemos ver en el gif no se moverán. Esto es debido a que al no tener un rigidbody no le afectarán las físicas como la gravedad.

  ![gif](gif/1_a.gif)

&nbsp;&nbsp;&nbsp;&nbsp;**b. La esfera tiene físicas, el cubo no.**

&nbsp;&nbsp;&nbsp;&nbsp;En este ejemplo podemos ver como el cubo sigue sin tener físicas por lo que no tiene ningún movimiento mientras que la esfera al tener un rigidbody se ve afectada por la gravedad y como tiene una masa tiende a caer.

  ![gif](gif/1_b.gif)

&nbsp;&nbsp;&nbsp;&nbsp;**c. La esfera y el cubo tienen físicas.**

&nbsp;&nbsp;&nbsp;&nbsp;En esto otro ejemplo ya los dos elementos tienen sus rigidbody por lo que se ven afectado por las físicas y tiende a caer.

  ![gif](gif/1_c.gif)

&nbsp;&nbsp;&nbsp;&nbsp;**d. La esfera y el cubo son físicos y la esfera tienen 10 veces la masa del cubo.**

&nbsp;&nbsp;&nbsp;&nbsp;Para este ejemplo vamos a ver como afecta la colisión de la esfera con el cubo. Es decir, cuanto lo desplaza.

  - Si la esfera como el cubo tuvieran la misma masa este sería el desplazamiento tras la colisión.

  ![gif](gif/1_d_massx1.gif)

  - Podemos observar en este gif que al tener la esfera 10 veces mas de masa, desplaza el cubo una mayor distancia.

  ![gif](gif/1_d_massx10.gif)

&nbsp;&nbsp;&nbsp;&nbsp;**e. La esfera tiene físicas y el cubo es de tipo IsTrigger.**

&nbsp;&nbsp;&nbsp;&nbsp;En este ejemplo, la esfera tiene físicas por lo que tiende a caer y rotar, pero el cubo no tiene físicas por lo que no se mueve y además al activarle la opción IsTrigger no detecta la colisión de la esfera por lo que la esfera traspasa el cubo.

  ![gif](gif/1_e.gif)

&nbsp;&nbsp;&nbsp;&nbsp;**f. La esfera tiene físicas y el cubo es de tipo IsTrigger y tiene físicas.**

&nbsp;&nbsp;&nbsp;&nbsp;En este otro ejemplo, el cubo sigue teniendo activa la opción IsTrigger por lo que no detecta las colisiones pero además ahora tiene un rigidbody por lo que le afectan las físicas. Al afectarles las físicas tiende a caer pero como no detecta las colisiones traspasa el plano.

  ![gif](gif/1_f.gif)

&nbsp;&nbsp;&nbsp;&nbsp;**g. La esfera y el cubo son físicos y la esfera tiene 10 veces la masa del cubo, se impide la rotación del cubo sobre el plano XZ.**

&nbsp;&nbsp;&nbsp;&nbsp;Este ejemplo es el mismo que el del apartado d pero bloqueando dos ejes. Lo que pasa que al bloquear los ejes ya no tenemos una vibración al chocar con el elemento.

  ![gif](gif/1_g.gif)

&nbsp;&nbsp;&nbsp;&nbsp;En este gif podemos ver como no podemos mover los ejes xz solo y.

  ![gif](gif/1_g_block.gif)

**2 Sobre la escena que has trabajado ubica un cubo que represente un personaje que vas a mover. Se debe implementar un script que haga de CharacterController.**
**Cuando el jugador pulse las teclas de flecha (o aswd) el jugador se moverá en la dirección que estos ejes indican.**

&nbsp;&nbsp;&nbsp;&nbsp;**a. Crear un script para el personaje que lo desplace por la pantalla, sin aplicar simulación física.**

![img](img/CharacterController.png)

![gif](gif/2_a.gif)

&nbsp;&nbsp;&nbsp;&nbsp;**b. Agregar un campo público que permita graduar la velocidad de movimiento desde el inspector de objetos.**

&nbsp;&nbsp;&nbsp;&nbsp;Al declarar el campo de speed como público podemos modificarlo a través del inspector

![img](img/campo_velocidad.PNG)

&nbsp;&nbsp;&nbsp;&nbsp;**c. Estar a la escucha de si el usuario ha utilizado los ejes virtuales. Elegir cuáles se van a utilizar: flechas, awsd.**

&nbsp;&nbsp;&nbsp;&nbsp;Al utilizar GetAxis te detecta tanto awsd como las flechas como entras de teclado para el movimiento del personaje.


&nbsp;&nbsp;&nbsp;&nbsp;**d. Elegir otros ejes virtuales para el giro y girar el jugador sobre el eje OY (up).**

![img](img/rotacionCharacterController.png)

![gif](gif/2_d.gif)

&nbsp;&nbsp;&nbsp;&nbsp;**3 Sobre la escena que has trabajado programa los scripts necesarios para las siguientes acciones:**

&nbsp;&nbsp;&nbsp;&nbsp;**a. Se deben incluir varios cilindros sobre la escena. Cada vez que el objeto jugador colisione con alguno de ellos, deben aumentar su tamaño y el jugador aumentar su puntuación.**

&nbsp;&nbsp;&nbsp;&nbsp;Este método detecta cuando nuestro personaje colisiona y va mostrando su puntuación

![img](img/collision_character.png)

&nbsp;&nbsp;&nbsp;&nbsp;Este método comprueba si le colisionan y si es el personaje quien lo hace. Si es así, aumenta su tamaño.

![img](img/collision_default_cylinder.png)

![gif](gif/3_a.gif)

&nbsp;&nbsp;&nbsp;&nbsp;**b. Agregar cilindros de tipo A, en los que además, si el jugador pulsa la barra espaciadora lo mueve hacia duera de él**

&nbsp;&nbsp;&nbsp;&nbsp;**c. Se deben incluir cilindros que se alejen del jugador cuando esté próximo**

&nbsp;&nbsp;&nbsp;&nbsp;**d. Ubicar un tercer objeto que sea capaz de detectar colisiones y que se mueva con las teclas I, L, J, M**

&nbsp;&nbsp;&nbsp;&nbsp;**e. Debes ubicar cubos que aumentan de tamaño cuando se acerca una esfera y que disminuye cuando se acerca el jugador**






