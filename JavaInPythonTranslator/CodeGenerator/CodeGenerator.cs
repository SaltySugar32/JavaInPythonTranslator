﻿namespace JavaInPythonTranslator
{
    internal class CodeGenerator
    {
        /*
         * ----------------------------------------------------------------------------------------
         * ----------------------------------Генератор кода----------------------------------------
         * 
         *      Генератор кода переводит синтаксически корректную программу на Java в программу на 
         * Python. Дерево, построенное синтаксическим анализатором используется, чтобы перевести
         * входную программу на Java в программу на Python при помощи таблицы соотвествия.
         * 
         * ----------------------------------------------------------------------------------------
         * -------------------------------------Пример---------------------------------------------
         * 
         *      Пусть имеется "дерево разбора" для 'System.out.print((i2+i3)*i4);':
         *          
         *                N1
         *          
         *            /        \
         *   
         * System.out.print     N2
         *            
         *                    /   |   \
         *            
         *                  N3    *     i4
         * 
         *              /   |   \
         * 
         *            i2    +     i3
         * 
         *      И "таблица соответсвия", сопоставляющая элементам Java элементы Python:
         *  _______________________________________  
         *      -Java-          |      -Python-
         *  --------------------|------------------
         *  System.out.print(); | print()
         *  boolean             | bool
         *                  и т.д.
         *      
         *      В результате отображения получим новое дерево:
         *      
         *                N1
         *          
         *            /        \
         *   
         *         print         N2
         *            
         *                    /   |   \
         *            
         *                  N3    *     i4
         * 
         *              /   |   \
         * 
         *            i2    +     i3
         *       
         *       Обойдя которое получим исходную инструкцию на языке Python: 'print((i2+i3)*i4)'
         *       
         * ----------------------------------------------------------------------------------------
         * -----------------------------------------Алгоритм---------------------------------------
         *      
         *      Алгоритм (общий):
         *      
         *      1. Пройти по синтаксическому дереву. 
         *      2. Отобразить элементы языка Java (отдельные лексемы, структура программы,
         * процедур и функций) в элементы языка Python.
         *      3. Записать обход полученного дерева в файл.
         *      4. Полученый файл содержит код программы на языке Python.
         *      
         *      
         *      Функция, отображающая вершины дерева:
         *      Translate(Node n):
         *          1. Если n!=null 
         *               1.1. Отобразить содержимое вершины n в новое по таблице соответствия
         *               1.2. Отобразить левое поддерево Translate(n.left)
         *               1.3. Отобразить правое поддерево Translate(n.right)
         *          2. Вернуть n
         * 
         * ----------------------------------------------------------------------------------------
         * 
         * */
    }
}
