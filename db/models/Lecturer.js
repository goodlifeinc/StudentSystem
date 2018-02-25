
module.exports = function (sequelize, DataTypes) {
    const Sale = sequelize.define('Lecturer', {
        id: {
            type: DataTypes.INTEGER,
            autoIncrement: true,
            primaryKey: true
        },
        title: {
            type: DataTypes.STRING
        },
        faculty: {
            type: DataTypes.INTEGER
        },
        specialties: {
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