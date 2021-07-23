Feature: Dar mantenimiento a un diccionario de llave - valor donde la llave es entero y el valor un string
   In order to listar, agregar, editar y eliminar valores a un diccionario de strings
   As a administrador del módulo de diccionario
   I want to contar con una lista de entradas llave - valor y poder agregar un valor nuevo, editar y eliminar un valor existente.

Scenario: Obtener todos los valores en el diccionario de datos
   Given se desea conocer la lista de todos los valores en el diccionario 
   When yo no envio parámetros
   Then retorna @Task<IEnumerable<LlaveValor>>
	| Llave | Valor      |
	| 1     | Corrales   | 
	| 2     | Agüero     | 
	| 3     | Esquivel   | 

Scenario: Obtener un valor por llave
   Given se desea obtener el valor al dar la llave
   When  envío la llave @int 1
   Then  retorna @Task<string>  Corrales

Scenario: Obtener un objeto por llave 
   Given se desea obtener el objeto al dar la llave
   When  envío la llave @int 1
   Then retorna @Task<IEnumerable<LlaveValor>>
	| Llave | Valor      |
	| 1     | Corrales   | 	

Scenario: Obtener un valor por llave da error cuando la llave no existe en el diccionario
   Given se desea conocer el valor
   When  envío la llave @int 0
   Then  se recibe excepción @Task<LlaveValorException>

Scenario: Agregar un valor
   Given se desea agregar un valor
   When  envío un valor @string Araya
   Then retorna @Task<int> 4    

Scenario: Agregar un valor falla cuando se envía un objeto nulo
   Given se desea agregar un vendedor
   When  envío un vendedor nulo @string null
   Then  se recibe excepción @Task<LlaveValorException>

Scenario: Editar un valor
   Given se desea editar un valor
   When envio la llave @int 2
    And envio el valor @string Matamoros
   Then se edita el valor y se retorna @Task<int> 2   

Scenario: Editar un valor falla por enviar el valor nulo
   Given se desea editar un valor
   When envio la llave @int 2
    And envio el valor @string null
   Then  se recibe excepción @Task<LlaveValorException>

Scenario: Editar un valor falla por enviar una llave inexistente
   Given se desea editar un valor
   When envio la llave @int 12
    And envio el valor @string Aguirre
   Then  se recibe excepción @Task<LlaveValorException>

Scenario: Eliminar un valor
   Given se desea eliminar un valor
   When  envío el id del valor @int 3
   Then retorna @Task<int> 3

Scenario: Eliminar un vendedor da error cuando la llave no se encuentra en el diccionario
   Given se desea eliminar un valor
   When  envío llave @int 0
   Then  se recibe excepción @Task<LlaveValorException>
