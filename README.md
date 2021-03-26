# test_task_for_backend_course
Данное приложение предназначено для подсчёта уникальных слов в тексте HTML-страниц.
Для запуска приложения необходимо дважды нажать левой кнопкой мыши на файл SimbirSoftTestAppWinForms.exe
После запуска приложения появляется окно, где пользователь может выбрать:
1. Скачать html-страницу или
2. Выбрать уже скачанную страницу с локального диска для анализа текста

ВАЖНО!
При вводе адреса html-страницы для скачивания необходимо проверить правильность её
написания (например, https://www.yandex.ru/ является корректным адресом для скачивания, а https://www.y - нет).
Далее после нажатия кнопки "Начать анализ" появляется надпись "Проводится анализ...", которая сообщает о корректной работе программы
(то есть отсутствует зависание).
По окончанию анализа надпись изменияется на "Анализ завершен!" и появляется сообщение о возможности сохранения результата
в файл формата txt. Если пользователь желает сохранить результат, ему необходимо выбрать папку для сохранения и присвоить имя новому файлу.
В случае возникновения ошибок программа не прекращает свою работу. Все ошибки, возникшие в результате работы программы 
сохраняются в отдельный файл формата txt, который находится в каталоге программы (папка Logs).