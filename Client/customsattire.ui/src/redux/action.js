import axios from "axios";
import * as types from "./actionType";

const getcustomers = (Customers) => ({
  type: types.GET_CUSTOMERS,
  payload: Customers,
});

const deletedcustomer = () => ({
  type: types.DELETE_CUSTOMER,
});

const addCustomer = (Customersdata) => ({
  type: types.ADD_CUSTOMER,
  payload: Customersdata,
});

const updateCustomer = (Customersdata) => ({
  type: types.UPDATE_CUSTOMER,
  payload: Customersdata,
});

const getSuppliers = (Suppliers) => ({
  type: types.GET_SUPPLIERS,
  payload: Suppliers,
});

const deletedSupplier = () => ({
  type: types.DELETE_SUPPLIERS,
});
const addSupplier = (Suppliersdata) => ({
  type: types.ADD_SUPPLIERS,
  payload: Suppliersdata,
});
const getpurchaseOrders = (PurchaseOrders) => ({
  type: types.GET_PURCHASEORDERS,
  payload: PurchaseOrders,
});

export const loadCustomers = () => {
  return function (dispatch) {
    //console.log(`${process.env.REACT_APP_API}/customer`);
    axios
      .get(`${process.env.REACT_APP_BASE_API_URL}/customer`)
      .then((resp) => {
        //console.log("resp", resp);
        dispatch(getcustomers(resp.data));
      })
      .catch((error) => console.log(error));
  };
};

export const deleteCustomer = (id) => {
  return function (dispatch) {
    axios
      .delete(`${process.env.REACT_APP_BASE_API_URL}/customer/${id}`)
      .then((resp) => {
        //console.log("resp", resp);
        dispatch(deletedcustomer());
        dispatch(getcustomers());
      })
      .catch((error) => console.log(error));
  };
};

export const addCustomers = (customer) => {
  return function (dispatch) {
    // console.log(`${process.env.REACT_APP_BASE_API_URL}/customer`);
    // console.log(customer);
    axios
      .post(`${process.env.REACT_APP_BASE_API_URL}/customer`, customer)
      .then((resp) => {
        //console.log("resp", resp);
        dispatch(addCustomer());
        dispatch(getcustomers());
      })
      .catch((error) => console.log(error));
  };
};

export const updateCustomers = (customer, id) => {
  return function (dispatch) {
    // console.log(`${process.env.REACT_APP_BASE_API_URL}/customer`);
    // console.log("updateCustomers --->" + customer.row);
    console.log("updateCustomers" + id);
    axios
      .put(`${process.env.REACT_APP_BASE_API_URL}/customer/${id}`, customer)
      .then((resp) => {
        console.log("resp", resp);
        dispatch(updateCustomer());
        dispatch(getcustomers());
      })
      .catch((error) => console.log(error));
  };
};
// SUPPLIERS API CALLS
export const loadSuppliers = () => {
  return function (dispatch) {
    //console.log(`${process.env.REACT_APP_BASE_API_URL}/vendor`);
    axios
      .get(`${process.env.REACT_APP_BASE_API_URL}/vendor`)
      .then((resp) => {
        //console.log("resp", resp);
        dispatch(getSuppliers(resp.data));
      })
      .catch((error) => console.log(error));
  };
};

export const deleteSupplier = (id) => {
  return function (dispatch) {
    axios
      .delete(`${process.env.REACT_APP_BASE_API_URL}/vendor/${id}`)
      .then((resp) => {
        //console.log("resp", resp);
        dispatch(deletedSupplier());
        dispatch(getSuppliers());
      })
      .catch((error) => console.log(error));
  };
};

export const addSuppliers = (supplier) => {
  return function (dispatch) {
    // console.log(`${process.env.REACT_APP_BASE_API_URL}/vendor`);
    // console.log("addSuppliers--->" + supplier);
    axios
      .post(`${process.env.REACT_APP_BASE_API_URL}/vendor`, supplier)
      .then((resp) => {
        // console.log("resp", resp);
        dispatch(addSupplier());
        dispatch(getSuppliers());
      })
      .catch((error) => console.log(error));
  };
};
export const updateSupplier = (supplier, id) => {
  return function (dispatch) {
    // console.log(`${process.env.REACT_APP_BASE_API_URL}/customer`);
    // console.log("updateCustomers --->" + customer.row);
    console.log("updateSuppliers" + id);
    axios
      .put(`${process.env.REACT_APP_BASE_API_URL}/vendor/${id}`, supplier)
      .then((resp) => {
        console.log("resp", resp);
        dispatch(updateSupplier());
        dispatch(getSuppliers());
      })
      .catch((error) => console.log(error));
  };
};
export const loadPurchaseOrders = () => {
  return function (dispatch) {
    console.log(`${process.env.REACT_APP_BASE_API_URL}/purchaseorders`);
    axios
      .get(`${process.env.REACT_APP_API}/purchaseorders`)
      .then((resp) => {
        console.log("resp", resp);
        dispatch(getpurchaseOrders(resp.data));
      })
      .catch((error) => console.log(error));
  };
};
