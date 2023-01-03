#include <iostream>
using namespace std;

int main() {
	/*
	 * Escribe un programa que muestre por consola (con un print) los
	 * n�meros de 1 a 100 (ambos incluidos y con un salto de l�nea entre
	 * cada impresi�n), sustituyendo los siguientes:
	 * - M�ltiplos de 3 por la palabra "fizz".
	 * - M�ltiplos de 5 por la palabra "buzz".
	 * - M�ltiplos de 3 y de 5 a la vez por la palabra "fizzbuzz".
	 */

	for (short i = 0; i < 100; i++){
		if (i % 3 == 0 && i % 5 == 0) {
			cout << "fizzbuzz\n";
		}
		else if(i % 3 == 0) {
			cout << "fizz\n";

		}
		else if(i % 5 == 0) {
			cout << "buzz\n";
		
		}
		else {
			cout << i << endl;
		}

	}

	return 0;
}