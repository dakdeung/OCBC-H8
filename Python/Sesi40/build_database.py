import os
from datetime import datetime
from config import db
from models import Avocado, Type, Region

# Data to initialize database with
AVOCADO = [
    {
        "date": "2015-01-04",
        "avgprice": "1.22",
        "totalvol": 40873.28,
        "avo_a": 2819.5,
        "avo_b": "28287.42",
        "avo_c": "49.9",
        "type": 1,
        "regionid": 1
    },
]

# Delete database file if it exists currently
if os.path.exists('avocado.db'):
    os.remove('avocado.db')

# Create the database
db.create_all()

# Iterate over the PEOPLE structure and populate the database
# for avocado in AVOCADO:
#     p = Person(lname=avocado.get("lname"), fname=avocado.get("fname"))

#     # Add the notes for the person
#     for type in avocado.get("type"):
#         content, timestamp = note
#         p.notes.append(
#             Note(
#                 content=content,
#                 timestamp=datetime.strptime(timestamp, "%Y-%m-%d %H:%M:%S"),
#             )
#         )
#     db.session.add(p)

db.session.commit()