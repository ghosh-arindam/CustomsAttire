// import React, { useState, useEffect } from "react";
// import { Box, Typography, useTheme } from "@mui/material";
// import { DataGrid } from "@mui/x-data-grid";
// import { tokens } from "../../theme";
// import Header from "../../components/Header";
// import { useDispatch, useSelector } from "react-redux";

// const PurchaseOrders = () => {
//   const theme = useTheme();
//   const colors = tokens(theme.palette.mode);
//   //   const [purchaseorders, setPurchaseorders] = useState();

//   const [pageSize, setPageSize] = useState(5);
//   const [rowId, setrowId] = useState();
//   const dispatch = useDispatch();
//   const PurchaseOrdersState = useSelector((state) => state.PurchaseOrdersState);
//   useEffect(() => {
//     dispatch(loadCustomers());
//     // eslint-disable-next-line react-hooks/exhaustive-deps
//   }, []);
//   const columns = [
//     { field: "id", headerName: "ID" },
//     {
//       field: "name",
//       headerName: "Name",
//       flex: 1,
//       cellClassName: "name-column--cell",
//     },
//     {
//       field: "phone",
//       headerName: "Phone Number",
//       flex: 1,
//     },
//     {
//       field: "email",
//       headerName: "Email",
//       flex: 1,
//     },
//     {
//       field: "cost",
//       headerName: "Cost",
//       flex: 1,
//       renderCell: (params) => (
//         <Typography color={colors.greenAccent[500]}>
//           ${params.row.cost}
//         </Typography>
//       ),
//     },
//     {
//       field: "date",
//       headerName: "Date",
//       flex: 1,
//     },
//   ];

//   return (
//     <Box m="20px">
//       <Header title="PURCHASE ORDERS" subtitle="List of Purchase Orders Made" />
//       <Box
//         m="40px 0 0 0"
//         height="75vh"
//         sx={{
//           "& .MuiDataGrid-root": {
//             border: "none",
//           },
//           "& .MuiDataGrid-cell": {
//             borderBottom: "none",
//           },
//           "& .name-column--cell": {
//             color: colors.greenAccent[300],
//           },
//           "& .MuiDataGrid-columnHeaders": {
//             backgroundColor: colors.blueAccent[700],
//             borderBottom: "none",
//           },
//           "& .MuiDataGrid-virtualScroller": {
//             backgroundColor: colors.primary[400],
//           },
//           "& .MuiDataGrid-footerContainer": {
//             borderTop: "none",
//             backgroundColor: colors.blueAccent[700],
//           },
//           "& .MuiCheckbox-root": {
//             color: `${colors.greenAccent[200]} !important`,
//           },
//         }}
//       >
//         <DataGrid
//           checkboxSelection
//           rows={fetchPurchaseOrders}
//           columns={columns}
//         />
//       </Box>
//     </Box>
//   );
// };

// export default PurchaseOrders;

import { Box, Button, useTheme } from "@mui/material";
import { DataGrid, GridToolbar } from "@mui/x-data-grid";
import { tokens } from "../../theme";
import Header from "../../components/Header";
import React, { useState, useEffect, useMemo } from "react";
import { useNavigate } from "react-router-dom";
import { useDispatch, useSelector } from "react-redux";
import AddIcon from "@mui/icons-material/Add";
import moment from "moment/moment";

const Purchase = () => {
    const theme = useTheme();
    const colors = tokens(theme.palette.mode);
    const [pageSize, setPageSize] = useState(5);
    const [rowId, setrowId] = useState();
    const navigate = useNavigate();
    const dispatch = useDispatch();
    const { purchases } = useSelector((state) => state.data);

    useEffect(() => {
        // TODO: add dispatch to redux-action
    }, []);

    const rowDataPurchase = purchases?.map((purchase) => {
        return {
            id: purchase?.id,
            employeeid: purchase?.employeeId,
            fabriccode: purchase?.fabricCode,
            supplierid: purchase?.supplierId,
            quantity: purchase?.quantity,
            costpm: purchase?.costPricePerMeter,
            totalcp: purchase?.totalCostPrice,
            duepayment: purchase?.duePayment,
            paymentmode: purchase?.paymentMode,
            purchasecompleted: purchase?.purchaseCompleted,
        };
    });

    const columns = useMemo(
        () => [
            {
                field: "id",
                headerName: "ID",
                flex: 0.5,
            },
            {
                field: "employeeid",
                headerName: "Employee ID",
                flex: 1,
                type: "singleSelect",
                editable: true,
            },
            {
                field: "fabriccode",
                headerName: "Fabric Code",
                flex: 1,
                type: "singleselect",
                editable: true,
            },
            {
                field: "supplierid",
                headerName: "Supplier ID",
                flex: 1,
                type: "singleselect",
                editable: true,
            },
            {
                field: "quantity",
                headerName: "Quantity",
                flex: 1,
                editable: true,
            },
            {
                field: "costpm",
                headerName: "Cost Price Per Meter",
                flex: 1,
                editable: true,
            },
            {
                field: "totalcp",
                headerName: "Total Cost Price",
                flex: 1,
                editable: false,
            },
            {
                field: "duepayment",
                headerName: "Due Payment",
                type: "date",
                headerAlign: "left",
                align: "left",
                editable: true,
                renderCell: (params) => moment(params.row.duePayment).format("yyyy-mm-dd"),
            },
            {
                field: "paymentmode",
                headerName: "Payment Mode",
                type: "singleselect",
                flex: 1,
                editable: true,
            },
            {
                field: "purchasecompleted",
                headerName: "Purchase Completed",
                type: "date",
                headerAlign: "left",
                align: "left",
                editable: true,
                renderCell: (params) => moment(params.row.purchaseCompleted).format("yyyy-mm-dd"),
            },
        ],
        [rowId]
    );

    return (
        <Box m = "20px">
            <Header title="PURCHASES" subtitle="List of purchases" />
            <Button
                variant="outlined"
                color="primary"
                startIcon={<AddIcon />}
                onClick={() => navigate("/AddPurchase")}
            >
                Add Purchase
            </Button>
            <Box
                m="40px 0 0"
                height="75vh"
                sx={{
                    "& .MuiDataGrid-root": {
                        border: "none",
                      },
                      "& .MuiDataGrid-cell": {
                        borderBottom: "none",
                      },
                      "& .name-column--cell": {
                        color: colors.greenAccent[300],
                      },
                      "& .MuiDataGrid-columnHeaders": {
                        backgroundColor: colors.blueAccent[700],
                        borderBottom: "none",
                      },
                      "& .MuiDataGrid-virtualScroller": {
                        backgroundColor: colors.primary[400],
                      },
                      "& .MuiDataGrid-footerContainer": {
                        borderTop: "none",
                        backgroundColor: colors.blueAccent[700],
                      },
                      "& .MuiCheckbox-root": {
                        color: `${colors.greenAccent[200]} !important`,
                      },
                      "& .MuiDataGrid-toolbarContainer .MuiButton-text": {
                        color: `${colors.grey[100]} !important`,
                      },
                }}
            >
            </Box>
        </Box>
    );
};

export default Purchase;
