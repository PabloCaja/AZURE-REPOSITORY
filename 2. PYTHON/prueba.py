import json
import datetime

for i in range(12):
    mydate = datetime.datetime(2022, i + 1, 1)
    #datetime.datetime.now()
    current = datetime.datetime(mydate.year, mydate.month, 1)
    nombremes = mydate.strftime("%B")
    print(nombremes)

# data = {
#     'employees' : [
#         {
#             'name' : 'John Doe',
#             'department' : 'Marketing',
#             'place' : 'Remote'
#         },
#         {
#             'name' : 'Jane Doe',
#             'department' : 'Software Engineering',
#             'place' : 'Remote'
#         },
#         {
#             'name' : 'Don Joe',
#             'department' : 'Software Engineering',
#             'place' : 'Office'
#         }
#     ]
# }

# .dumps() as a string
# json_string = json.dumps(data)
# #print(json_string)
# for i in data['employees']:
#     print(i["name"])

# Opening JSON file
f = open("jugadores_nokey.json", "r")
  
# returns JSON object as 
# a dictionary
data = json.load(f)
  
# Iterating through the json
# list
for i in data:
    print(i["nombre"])
  
# Closing file
f.close()

#json string data
# newPlayer = {
#   "numero": 55,
#   "nombre": "Error Garcia",
#   "posicion": "No se conoce",
#   "edad": 99,
#   "imagen": ""
# }
# #'{"numero": 4, "nombre": "Rodgers", "posicion": "Marketing","edad":99,"imagen": ""}'
# data.append(newPlayer)
# json_string = json.dumps(data)
# f = open("jugadores_nokey.json", "w+")
# f.write(json_string)
# f.flush()
# print("Todo correcto")
# f.close()