import axios from "axios";
import * as types from "./actionType";

const getcustomers = (Customersdata) => ({
  type: types.GET_CUSTOMERS,
  payload: Customersdata,
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
const addpurchaseOrders = (PurchaseOrders) => ({
  type: types.ADD_PURCHASEORDERS,
  payload: PurchaseOrders,
});
const deletedpurchaseOrders = () => ({
  type: types.ADD_PURCHASEORDERS,
});
const addproduct = (Product) => ({
  type: types.ADD_PRODUCT,
  payload: Product,
});
const getProduct = (Product) => ({
  type: types.GET_PRODUCT,
  payload: Product,
});
const getsalesOrders = (SalesOrders) => ({
  type: types.GET_SALESORDERS,
  payload: SalesOrders,
});
const addsalesOrders = (SalesOrders) => ({
  type: types.ADD_SALESORDERS,
  payload: SalesOrders,
});
const deletedsalesOrders = () => ({
  type: types.DELETE_SALESORDER,
});
export const loadCustomers = () => {
  return async function (dispatch) {
    //console.log(`${process.env.REACT_APP_BASE_API_URL}/Customer`);
    await axios
      .get(`${process.env.REACT_APP_BASE_API_URL}/customer`)
      .then((resp) => {
        //console.log("resp", resp);
        dispatch(getcustomers(resp.data));
      })
      .catch((error) => console.log(error));
  };
};

export const deleteCustomer = (id) => {
  return async function (dispatch) {
    await axios
      .delete(`${process.env.REACT_APP_BASE_API_URL}/customer/${id}`)
      .then((resp) => {
        //console.log("resp", resp);
        dispatch(deletedcustomer(resp.data));
      })
      .catch((error) => console.log(error));
  };
};

export const addCustomers = (customer) => {
  return async function (dispatch) {
    // console.log(`${process.env.REACT_APP_BASE_API_URL}/customer`);
    // console.log(customer);
    await axios
      .post(`${process.env.REACT_APP_BASE_API_URL}/customer`, customer)
      .then((resp) => {
        //console.log("resp", resp);
        dispatch(addCustomer(resp.data));
        //dispatch(getcustomers());
      })
      .catch((error) => console.log(error));
  };
};

export const updateCustomers = (customer, id) => {
  return async function (dispatch) {
    //console.log(`${process.env.REACT_APP_BASE_API_URL}/customer/${id}`);
    await axios
      .put(`${process.env.REACT_APP_BASE_API_URL}/customer/${id}`, customer)
      .then((resp) => {
        //console.log("*** action:", resp.data);
        dispatch(updateCustomer(resp.data));
      })
      .catch((error) => console.log(error));
  };
};
// SUPPLIERS API CALLS
export const loadSuppliers = () => {
  return async function (dispatch) {
    //console.log(`${process.env.REACT_APP_BASE_API_URL}/vendor`);
    await axios
      .get(`${process.env.REACT_APP_BASE_API_URL}/vendor`)
      .then((resp) => {
        //console.log("resp", resp);
        dispatch(getSuppliers(resp.data));
      })
      .catch((error) => console.log(error));
  };
};

export const deleteSupplier = (id) => {
  return async function (dispatch) {
    await axios
      .delete(`${process.env.REACT_APP_BASE_API_URL}/vendor/${id}`)
      .then((resp) => {
        //console.log("resp", resp);
        dispatch(deletedSupplier(resp.data));
      })
      .catch((error) => console.log(error));
  };
};

export const addSuppliers = (supplier) => {
  return async function (dispatch) {
    // console.log(`${process.env.REACT_APP_BASE_API_URL}/vendor`);
    // console.log("addSuppliers--->" + supplier);
    await axios
      .post(`${process.env.REACT_APP_BASE_API_URL}/vendor`, supplier)
      .then((resp) => {
        // console.log("resp", resp);
        dispatch(addSupplier(resp.data));
      })
      .catch((error) => console.log(error));
  };
};
export const updateSupplier = (supplier, id) => {
  return async function (dispatch) {
    // console.log(`${process.env.REACT_APP_BASE_API_URL}/customer`);
    // console.log("updateCustomers --->" + customer.row);
    // console.log("updateSuppliers" + id);
    await axios
      .put(`${process.env.REACT_APP_BASE_API_URL}/vendor/${id}`, supplier)
      .then((resp) => {
        console.log("resp", resp);
        dispatch(updateSupplier(resp.data));
      })
      .catch((error) => console.log(error));
  };
};
export const loadPurchaseOrders = () => {
  return async function (dispatch) {
    // console.log(`${process.env.REACT_APP_BASE_API_URL}/PurchaseOrders`);
    await axios
      .get(`${process.env.REACT_APP_BASE_API_URL}/PurchaseOrders`)
      .then((resp) => {
        //console.log("resp", resp);
        dispatch(getpurchaseOrders(resp.data));
      })
      .catch((error) => console.log(error));
  };
};
export const deletePurchaseOrders = (id) => {
  return async function (dispatch) {
    await axios
      .delete(`${process.env.REACT_APP_BASE_API_URL}/PurchaseOrders/${id}`)
      .then((resp) => {
        //console.log("resp", resp);
        dispatch(deletedpurchaseOrders(resp.data));
      })
      .catch((error) => console.log(error));
  };
};

export const addPurchaseOrders = (purchaseOrder) => {
  return async function (dispatch) {
    // console.log(`${process.env.REACT_APP_BASE_API_URL}/PurchaseOrders`);
    //console.log("addPurchaseOrders--->" + purchaseOrder);
    await axios
      .post(
        `${process.env.REACT_APP_BASE_API_URL}/PurchaseOrders`,
        purchaseOrder
      )
      .then((resp) => {
        //console.log("resp", resp);
        dispatch(addpurchaseOrders(resp.data));
      })
      .catch((error) => console.log(error));
  };
};
export const updatePurchaseOrders = (purchaseOrder, id) => {
  return async function (dispatch) {
    // console.log(`${process.env.REACT_APP_BASE_API_URL}/PurchaseOrders`);
    // console.log("updateCustomers --->" + customer.row);
    //console.log("updatePurchaseOrders" + id);
    await axios
      .put(
        `${process.env.REACT_APP_BASE_API_URL}/PurchaseOrders/${id}`,
        purchaseOrder
      )
      .then((resp) => {
        //console.log("resp", resp);
        dispatch(updatePurchaseOrders(resp.data));
      })
      .catch((error) => console.log(error));
  };
};
export const addProduct = (Product) => {
  return async function (dispatch) {
    // console.log(`${process.env.REACT_APP_BASE_API_URL}/Product`);
    // console.log("addProduct--->" + Product);
    await axios
      .post(`${process.env.REACT_APP_BASE_API_URL}/Product`, Product)
      .then((resp) => {
        // console.log("resp", resp);
        dispatch(addproduct(resp.data));
      })
      .catch((error) => console.log(error));
  };
};
export const loadProduct = () => {
  return async function (dispatch) {
    // console.log(`${process.env.REACT_APP_BASE_API_URL}/Product`);
    await axios
      .get(`${process.env.REACT_APP_BASE_API_URL}/Product`)
      .then((resp) => {
        //console.log("resp", resp);
        dispatch(getProduct(resp.data));
      })
      .catch((error) => console.log(error));
  };
};
export const loadSalesOrders = () => {
  return async function (dispatch) {
    // console.log(`${process.env.REACT_APP_BASE_API_URL}/salesOrderItems`);
    await axios
      .get(`${process.env.REACT_APP_BASE_API_URL}/salesOrderItems`)
      .then((resp) => {
        //console.log("resp", resp);
        dispatch(getsalesOrders(resp.data));
      })
      .catch((error) => console.log(error));
  };
};
export const addSalesOrders = (salesOrder) => {
  return async function (dispatch) {
    // console.log(`${process.env.REACT_APP_BASE_API_URL}/PurchaseOrders`);
    // console.log("addSalesOrders--->" + salesOrder);
    await axios
      .post(`${process.env.REACT_APP_BASE_API_URL}/SalesOrderItems`, salesOrder)
      .then((resp) => {
        console.log("resp", resp);
        dispatch(addsalesOrders(resp.data));
      })
      .catch((error) => console.log(error));
  };
};
export const updateSalesOrders = (salesOrder, id) => {
  return async function (dispatch) {
    // console.log(`${process.env.REACT_APP_BASE_API_URL}/PurchaseOrders`);
    // console.log("updateCustomers --->" + customer.row);
    //console.log("updatePurchaseOrders" + id);
    await axios
      .put(
        `${process.env.REACT_APP_BASE_API_URL}/SalesOrderItems/${id}`,
        salesOrder
      )
      .then((resp) => {
        console.log("resp", resp);
        dispatch(updateSalesOrders(resp.data));
      })
      .catch((error) => console.log(error));
  };
};
export const deleteSalesOrders = (id) => {
  return function (dispatch) {
    axios
      .delete(`${process.env.REACT_APP_BASE_API_URL}/SalesOrderItems/${id}`)
      .then((resp) => {
        //console.log("resp", resp);
        dispatch(deletedsalesOrders(resp.data));
      })
      .catch((error) => console.log(error));
  };
};
