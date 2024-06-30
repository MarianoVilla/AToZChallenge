import requests

r = requests.get('https://pokeapi.co/api/v2/stat/1')

print(r)
print(r.json()['characteristics'][0]['url'])