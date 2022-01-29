const articles = (state = {}, action) => {
    switch (action.type) {
        case 'NEW_ARTICLES':
            return { ...state, mylateststate: action.payload } //updated state
        default:
            return state //existing state or old state 
    }
}

export default articles