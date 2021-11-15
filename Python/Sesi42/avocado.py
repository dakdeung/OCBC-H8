from flask import make_response, abort
from config import db
from models import Avocado, AvocadoSchema


def read_all():
    """
    This function responds to a request for /api/people
    with the complete lists of people
    :return:        json string of list of people
    """
    # Create the list of people from our data
    avocado = Avocado.query.all().limit(5)

    # Serialize the data for the response
    person_schema = AvocadoSchema(many=True)
    data = person_schema.dump(avocado)
    return data