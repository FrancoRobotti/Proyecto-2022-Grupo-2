# Proyecto-2022-Grupo-2

Informe del UML

User:
    -   Guarda el nombre del usuario registrado.
    -   Permite crear/encontrar una partida.

Ship:
    -	Para crear un ship se decide una coordenada inicial, y la dirección a la que se va a extender el barco (la idea es que no pueda superar los bordes del tablero ni se 	     superponga con otros objetos).
    -	Van a existir 3 tipos de barcos, con largos de 2, 3 y 4 casillas.
    -	Por cada casilla a la que se extienda el barco se representara en forma de coordenadas, las cuales son strings que se almacenaran dentro de una lista de                     coordenadas.
    -	“Sunk” es la propiedad que define si el barco está hundido o no.

Bomb:
    -	Bomb posee una única coordenada donde está situada.
    -	Su método “Kaboom” crea da como atacadas las 8 casillas a su alrededor.

GameBoard:
    -	Es una matriz con un tamaño a decisión del jugador, que contiene una lista de “ships” y otra de “bombs”.
    -	Se actualizará cada vez que reciba un ataque.

Player:
    -	Contiene un “User” y un “GameBoard”.

Menu:
    -	Contiene las opciones del juego, que podrán ser cambiadas por el jugador antes de iniciar una partida.

Admin:
    -	Toma el Rol de Bot, ya que realiza todas las funcionalidades esenciales para el funcionamiento del programa.
    -	Registra Users
    -	Crea partidas en base a las opciones dadas por el usuario en el menú
    -	“AttackInfo” recibe la instrucción de atacar de un jugador y se la pasa a otra clase para que la ejecute
    -	“EndGame” termina el juego una vez que todos los barcos de un jugador hayan sido hundidos

MatchLogic:
    -	Recibe la instrucción de ataque de admin y la ejecuta en la partida.
    -	“Surrender” finaliza la partida en el momento que es llamada por un player.
    -	“PlaceShips” permite al usuario posicionar sus barcos a ambos jugadores antes de empezar la partida.
    -	Update actualiza los tableros después de haber sido atacados y los imprime en pantalla.

Match:
    -	Representa la partida en juego.
    -	Contiene 2 jugadores que serán los únicos capaces de atacar los tableros del otro jugador.
    
Printer:
    -	Imprime los tableros de 2 modos distintos.
    -	“PrintDefense” imprime el tablero de forma que, se dibujen los barcos del jugador que lo llamo.
    -	“PrintAttack” imprime el tablero con el registro de ataque que el jugador ha realizado sin revelar los barcos de su oponente.
