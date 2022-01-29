import { combineReducers } from 'redux'
import articles from './articlereducer'

const parentReducer = combineReducers({
    articles
})

export default parentReducer

//combineReducers - combines all the reducers together into a single package