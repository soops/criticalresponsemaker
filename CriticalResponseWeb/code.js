function saveFunction() {
    var allElements = (document.getElementsByName('name')[0].value +
                            '\n' + 'In the ' + document.getElementsByName('genre')[0].value + ' entitled ' + document.getElementsByName('titleofwork')[0].value + ', ' + document.getElementsByName('authorname')[0].value + ' wants us to ' + document.getElementsByName('knowunderstand')[0].value + ' ' +        document.getElementsByName('message')[0].value + '\n' + ' (transition sentence here) ' + document.getElementsByName('mainmessage1')[0].value + ' (transition sentence here) ' + document.getElementsByName('connection1')[0].value +
                           ' (transition sentence here) ' + document.getElementsByName('mainmessage2')[0].value + ' (transition sentence here) ' + document.getElementsByName('connection2')[0].value +
                           ' (transition sentence here ' + document.getElementsByName('mainmessage3')[0].value + ' (transition sentence here) ' + document.getElementsByName('connection3')[0].value +
                           document.getElementsByName('finalconnection')[0].value
                           );
    window.prompt("To copy, do CTRL+C and Enter!", allElements);

}