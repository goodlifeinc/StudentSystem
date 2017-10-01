const path = require('path');
const Sequelize = require('sequelize');

const sequelize = new Sequelize('simple_cashier', 'root', '', {
    host: '127.0.0.1',
    port: 3306,
    dialect: 'mysql'
  });

module.exports = () => {
    return {
        register: require('hapi-sequelize'),
        options: [ 
          {
            name: 'simple_cashier', // identifier
            models: ['./db/models/**/*.js'],  // paths/globs to model files
            sequelize: sequelize, // sequelize instance
            sync: true, // sync models - default false
            forceSync: true // force sync (drops tables) - default false
          }
        ]
    }
}