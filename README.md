# Práctica 2: Introducción a los scripts en Unity

- Autor: Adal Díaz Fariña
- Contacto: alu0101112251@ull.edu.es

**1 Crear una escena simple sobre la que probar diferentes configuraciones de objetos físicos en Unity. La escena debe tener un plano a modo de suelo, una esfera y un cubo.**

&nbsp;&nbsp;&nbsp;&nbsp;**a. Ninguno de los objetos será físico.**

&nbsp;&nbsp;&nbsp;&nbsp;Al ningún objeto ser físico como podemos ver en el gif no se moverán. Esto es debido a que al no &nbsp;&nbsp;&nbsp;&nbsp;tener un rigidbody no le afectarán las físicas como la gravedad.

  ![gif](gif/1_a.gif)

&nbsp;&nbsp;&nbsp;&nbsp;**b. La esfera tiene físicas, el cubo no.**

&nbsp;&nbsp;&nbsp;&nbsp;En este ejemplo podemos ver como el cubo sigue sin tener físicas por lo que no tiene ningún &nbsp;&nbsp;&nbsp;&nbsp;movimiento mientras que la esfera al tener un rigidbody se ve afectada por la gravedad y como tiene una &nbsp;&nbsp;&nbsp;&nbsp;masa tiende a caer.

  ![gif](gif/1_b.gif)

  **c. La esfera y el cubo tienen físicas.**

&nbsp;&nbsp;&nbsp;&nbsp;En esto otro ejemplo ya los dos elementos tienen sus rigidbody por lo que se ven afectado por las &nbsp;&nbsp;&nbsp;&nbsp;físicas y tiende a caer.

  ![gif](gif/1_c.gif)

  **d. La esfera y el cubo son físicos y la esfera tienen 10 veces la masa del cubo.**

&nbsp;&nbsp;&nbsp;&nbsp;Para este ejemplo vamos a ver como afecta la colisión de la esfera con el cubo. Es decir, cuanto &nbsp;&nbsp;&nbsp;&nbsp;lo desplaza.

  - Si la esfera como el cubo tuvieran la misma masa este sería el desplazamiento tras la colisión.

  ![gif](gif/1_d_massx1.gif)

  - Podemos observar en este gif que al tener la esfera 10 veces mas de masa, desplaza el cubo una mayor distancia.

  ![gif](gif/1_d_massx10.gif)

&nbsp;&nbsp;&nbsp;&nbsp;**e. La esfera tiene físicas y el cubo es de tipo IsTrigger.**

&nbsp;&nbsp;&nbsp;&nbsp;En este ejemplo, la esfera tiene físicas por lo que tiende a caer y rotar, pero el cubo no tiene &nbsp;&nbsp;&nbsp;&nbsp;físicas por lo que no se mueve y además al activarle la opción IsTrigger no detecta la colisión de &nbsp;&nbsp;&nbsp;&nbsp;la esfera por lo que la esfera traspasa el cubo.

  ![gif](gif/1_e.gif)

&nbsp;&nbsp;&nbsp;&nbsp;**f. La esfera tiene físicas y el cubo es de tipo IsTrigger y tiene físicas.**

&nbsp;&nbsp;&nbsp;&nbsp;En este otro ejemplo, el cubo sigue teniendo activa la opción IsTrigger por lo que no detecta las &nbsp;&nbsp;&nbsp;&nbsp;colisiones pero además ahora tiene un rigidbody por lo que le afectan las físicas. Al afectarles &nbsp;&nbsp;&nbsp;&nbsp;las físicas tiende a caer pero como no detecta las colisiones traspasa el plano.

  ![gif](gif/1_f.gif)

&nbsp;&nbsp;&nbsp;&nbsp;**g. La esfera y el cubo son físicos y la esfera tiene 10 veces la masa del cubo, se impide la &nbsp;&nbsp;&nbsp;&nbsp;rotación del cubo sobre el plano XZ.**

&nbsp;&nbsp;&nbsp;&nbsp;Este ejemplo es el mismo que el del apartado d pero bloqueando dos ejes. Lo que pasa que al &nbsp;&nbsp;&nbsp;&nbsp;bloquear los ejes ya no tenemos una vibración al chocar con el elemento.

  ![gif](gif/1_g.gif)

&nbsp;&nbsp;&nbsp;&nbsp;En este gif podemos ver como no podemos mover los ejes xz solo y.

  ![gif](gif/1_g_block.gif)








