import * as type from "./actionType";
const initialState = {
  customers: [],
  customer: {},
  suppliers: [],
  supplier: {},
  purchaseorders: [],
  purchaseorder: {},
  salesorders: [],
  salesorder: {},
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
    case type.GET_PRODUCT:
      return {
        ...state,
        Products: action.payload,
        loading: false,
      };
    case type.ADD_PRODUCT:
      return {
        ...state,
        loading: false,
      };
    case type.ADD_PURCHASEORDERS:
      return {
        ...state,
        loading: false,
      };
    case type.GET_PURCHASEORDERS:
      return {
        ...state,
        purchaseorders: action.payload,
        loading: false,
      };
    case type.DELETE_PURCHASEORDER:
      return {
        ...state,
        loading: false,
      };
    case type.ADD_SALESORDERS:
      return {
        ...state,
        loading: false,
      };
    case type.GET_SALESORDERS:
      return {
        ...state,
        salesorders: action.payload,
        loading: false,
      };
    case type.DELETE_SALESORDER:
      return {
        ...state,
        loading: false,
      };
    default:
      return state;
  }
};

export default Reducer;
