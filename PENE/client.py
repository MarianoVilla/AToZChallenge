import requests
import json
from types import SimpleNamespace

r = requests.get('https://pokeapi.co/api/v2/stat/1')
pokeClass = json.loads(r.text, object_hook=lambda d: SimpleNamespace(**d))
print(r)
#dogmatismo del POO
print(pokeClass.characteristics[0].url)
