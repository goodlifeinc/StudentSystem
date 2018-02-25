
module.exports = function (sequelize, DataTypes) {
    const Sale = sequelize.define('Specialty', {
        id: {
            type: DataTypes.INTEGER,
            autoIncrement: true,
            primaryKey: true
        },
        name: {
            type: DataTypes.STRING
        },
        faculty: {
            type: DataTypes.INTEGER
        },
        students: {
            type: DataTypes.STRING
        },
        lecturers: {
            type: DataTypes.INTEGER
        }
    });
    
    // Class Method
    Sale.associate = function (models) {
    };
    
    // Instance Method
    // Sale.prototype.someMethod = function () {
    // };

    return Sale;
};