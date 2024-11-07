
    var proxyAuth = {
        username: 'quang',
        password: 'quang'
    };

    chrome.webRequest.onAuthRequired.addListener(
        function(details) {
            return {
                authCredentials: { username: proxyAuth.username, password: proxyAuth.password }
            };
        },
        { urls: ['<all_urls>'] },
        ['blocking']
    );
    