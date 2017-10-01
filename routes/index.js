const path = require('path');

module.exports = () => {
    return {
        method: 'GET',
        path: '/{param*}',
        handler: {
            directory: {
                path: 'dist',
                listing: true,
                index: true
            }
        }
    }
}