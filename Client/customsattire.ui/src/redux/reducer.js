import * as type from "./actionType";
const initialState = {
  customers: [],
  customer: {},
  suppliers: [],
  supplier: {},
  loading: false,
};

const Reducer = (state = initialState, action) => {
  switch (action.type) {
    case type.GET_CUSTOMERS:
      return {
        ...state,
        customers: action.payload,
        loading: false,
      };
    case type.DELETE_CUSTOMER:
      return {
        ...state,
        loading: false,
      };
    case type.ADD_CUSTOMER:
      return {
        ...state,
        loading: false,
      };
    case type.GET_SUPPLIERS:
      return {
        ...state,
        suppliers: action.payload,
        loading: false,
      };
    case type.ADD_SUPPLIERS:
      return {
        ...state,
        loading: false,
      };
    case type.DELETE_SUPPLIERS:
      return {
        ...state,
        loading: false,
      };

    default:
      return state;
  }
};

export default Reducer;
