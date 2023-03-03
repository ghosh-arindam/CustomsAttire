import axios from "axios";
import * as types from "./actionType";

const getcustomers = (Customers) => ({
  type: types.GET_CUSTOMERS,
  payload: Customers,
});

const deletedcustomers = () => ({
  type: types.DELETE_CUSTOMER,
});

const addCustomer = (Customersdata) => ({
  type: types.ADD_CUSTOMER,
  payload: Customersdata,
});

const getSuppliers = (Suppliers) => ({
  type: types.GET_SUPPLIERS,
  payload: Suppliers,
});

const getpurchaseOrders = (PurchaseOrders) => ({
  type: types.GET_PURCHASEORDERS,
  payload: PurchaseOrders,
});

export const loadCustomers = () => {
  return function (dispatch) {
    //console.log(`${process.env.REACT_APP_API}/customer`);
    axios
      .get(`${process.env.REACT_APP_API}/customer`)
      .then((resp) => {
        console.log("resp", resp);
        dispatch(getcustomers(resp.data));
      })
      .catch((error) => console.log(error));
  };
};

export const deleteCustomer = (id) => {
  return function (dispatch) {
    axios
      .delete(`${process.env.REACT_APP_API}/customer/${id}`)
      .then((resp) => {
        console.log("resp", resp);
        dispatch(deletedcustomers());
        dispatch(getcustomers());
      })
      .catch((error) => console.log(error));
  };
};

export const addCustomers = (customer) => {
  return function (dispatch) {
    console.log(`${process.env.REACT_APP_API}/customer`);
    console.log(customer);
    axios
      .post(`${process.env.REACT_APP_API}/customer`, customer)
      .then((resp) => {
        console.log("resp", resp);
        dispatch(addCustomer());
        dispatch(getcustomers());
      })
      .catch((error) => console.log(error));
  };
};

export const loadSuppliers = () => {
  return function (dispatch) {
    //console.log(`${process.env.REACT_APP_API}/customer`);
    axios
      .get(`${process.env.REACT_APP_API}/vendor`)
      .then((resp) => {
        console.log("resp", resp);
        dispatch(getSuppliers(resp.data));
      })
      .catch((error) => console.log(error));
  };
};

export const loadPurchaseOrders = () => {
  return function (dispatch) {
    console.log(`${process.env.REACT_APP_API}/purchaseorders`);
    axios
      .get(`${process.env.REACT_APP_API}/purchaseorders`)
      .then((resp) => {
        console.log("resp", resp);
        dispatch(getpurchaseOrders(resp.data));
      })
      .catch((error) => console.log(error));
  };
};
