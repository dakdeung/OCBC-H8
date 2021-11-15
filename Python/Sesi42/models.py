# from datetime import datetime
# from config import db, ma

# class Avocado(db.Model):
# 		__tablename__ = 'avocado'
# 		# id = db.Column(db.Integer, primary_key=True)
# 		date = db.Column(db.String(32))
# 		avgprice = db.Column(db.String(32))
# 		totalvol = db.Column(db.Integer)
# 		avo_a = db.Column(db.Integer)
# 		avo_b = db.Column(db.String(32))
# 		avo_c = db.Column(db.String(32))
# 		regionid = db.Column(db.Integer)
# 		type = db.Column(db.Integer)
# 		# type = db.relationship(
# 		# 	'Type',
# 		# 	backref='avocado',
# 		# 	cascade='all, delete, delete-orphan',
# 		# 	single_parent=True,
# 		# )
# 		regionid = db.Column(db.Integer,  db.ForeignKey('avoregion.'))

# class Type(db.Model):
#     __tablename__ = 'avotype'
#     type_id = db.Column(db.Integer, primary_key=True)
#     type = db.Column(db.Integer)
# class Region(db.Model):
#     __tablename__ = 'avoregion'
#     regionid = db.Column(db.Integer, primary_key=True)
#     region = db.Column(db.String)


# class AvocadoSchema(ma.SQLAlchemyAutoSchema):
#     class Meta:
#         model = Avocado
#         sqla_session = db.session
#         load_instance = True
from datetime import datetime
from config import db, ma

class Avocado(db.Model):
    __tablename__ = 'avocado'
    #avocado_id = db.Column()
    regionid = db.Column(db.Integer, primary_key=True)
    avgprice = db.Column(db.REAL)
    totalvol = db.Column(db.Integer)
    avo_a = db.Column(db.Integer)
    avo_b = db.Column(db.Integer)
    avo_c = db.Column(db.Integer)
    type = db.Column(db.Integer)
    date = db.Column(db.DateTime, default=datetime.utcnow, onupdate=datetime.utcnow)

class AvocadoSchema(ma.SQLAlchemyAutoSchema):
    class Meta:
        model = Avocado
        sqla_session = db.session    
        load_instance = True