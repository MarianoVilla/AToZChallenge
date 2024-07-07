import requests
import json
from types import SimpleNamespace
import pandas as pd
from datetime import datetime

r = requests.get('https://dragonball-api.com/api/characters')

json_data = json.loads(r.text)

df = pd.json_normalize(json_data['items'])

current_date = datetime.now().strftime('%Y-%m-%d %H:%M:%S')
df['createdAt'] = current_date

# Save DataFrame to Excel
df.to_excel('characters.xlsx', index=False)

print("Excel file has been created successfully.")
