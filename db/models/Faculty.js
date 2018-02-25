
module.exports = function (sequelize, DataTypes) {
    const Sale = sequelize.define('Faculty', {
        id: {
            type: DataTypes.INTEGER,
            autoIncrement: true,
            primaryKey: true
        },
        name: {
            type: DataTypes.STRING
        },
        specialties: {
            type: DataTypes.STRING
        },
        students: {
            type: DataTypes.STRING
        },
        lecturers: {
            type: DataTypes.STRING
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