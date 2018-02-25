
module.exports = function (sequelize, DataTypes) {
    const Sale = sequelize.define('DiplomaWork', {
        id: {
            type: DataTypes.INTEGER,
            autoIncrement: true,
            primaryKey: true
        },
        title: {
            type: DataTypes.STRING
        },
        student: {
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