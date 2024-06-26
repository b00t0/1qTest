## Описание решения задачи

Программа реализует два основных метода:

### `LimitCharsOfArray`

Этот метод принимает два параметра: исходный массив строк (`array`) и ограничение по количеству символов (`limit`). Он создает новый массив такой же длины, что и исходный массив, и заполняет его строками, длина которых меньше значения `limit`. Для этого метод перебирает каждый элемент исходного массива и проверяет его длину. Если длина строки меньше, чем `limit`, она добавляется в новый массив.

### `PrintArray`

Этот метод принимает один параметр - массив строк (`array`). Он используется для вывода элементов массива на консоль. Метод проходит по всем элементам массива и печатает их, разделяя запятыми. Перед печатью он также проверяет, что элемент не является пустой строкой или `null`, чтобы избежать вывода ненужных символов.

Помимо этих методов, программа содержит основной блок кода, который запрашивает у пользователя размер и содержимое массива, затем вызывает метод `LimitCharsOfArray` для фильтрации массива и метод `PrintArray` для вывода результата на экран.
