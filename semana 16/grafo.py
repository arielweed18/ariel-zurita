# Grafo representado con diccionario

grafo = {
    "Quito": ["Guayaquil", "Cuenca"],
    "Guayaquil": ["Quito", "Manta", "Loja"],
    "Cuenca": ["Quito", "Loja"],
    "Manta": ["Guayaquil"],
    "Loja": ["Guayaquil", "Cuenca"]
}

# Mostrar todo el grafo
def mostrar_grafo(g):
    print("\n--- GRAFO COMPLETO ---")
    for nodo in g:
        print(nodo, "->", g[nodo])

# Buscar conexiones
def buscar_conexiones(g, ciudad):
    if ciudad in g:
        print("\nConexiones de", ciudad, ":", g[ciudad])
    else:
        print("Ciudad no encontrada")

# Agregar conexión
def agregar_conexion(g, c1, c2):
    if c1 in g:
        g[c1].append(c2)
    else:
        g[c1] = [c2]

    if c2 in g:
        g[c2].append(c1)
    else:
        g[c2] = [c1]

    print("Conexión agregada")

# Menú
while True:
    print("\n===== MENÚ =====")
    print("1. Ver grafo")
    print("2. Buscar conexiones")
    print("3. Agregar conexión")
    print("4. Salir")

    opcion = input("Elige una opción: ")

    if opcion == "1":
        mostrar_grafo(grafo)

    elif opcion == "2":
        ciudad = input("Ingrese ciudad: ")
        buscar_conexiones(grafo, ciudad)

    elif opcion == "3":
        c1 = input("Ciudad 1: ")
        c2 = input("Ciudad 2: ")
        agregar_conexion(grafo, c1, c2)

    elif opcion == "4":
        print("Fin del programa")
        break

    else:
        print("Opción inválida")
        