import { Box, Button, useTheme } from "@mui/material";
import { DataGrid, gridClasses, GridToolbar } from "@mui/x-data-grid";
import AddIcon from "@mui/icons-material/Add";
import { grey } from "@mui/material/colors";
import { tokens } from "../../theme";
import Header from "../../components/Header";
import React, { useState, useEffect, useMemo } from "react";
import { useNavigate } from "react-router-dom";
import { useDispatch, useSelector } from "react-redux";
import { loadPurchaseOrders } from "../../redux/action";

const PurchaseMaster = () => {
  const theme = useTheme();
  const colors = tokens(theme.palette.mode);
  const [pageSize, setPageSize] = useState(5);
  const [selectedrowId, setselectedrowId] = useState([]);
  const navigate = useNavigate();
  const dispatch = useDispatch();

  const { purchaseorders } = useSelector((state) => state.data);
  console.log(purchaseorders);
  const [sortModel, setSortModel] = useState([
    {
      field: "rowId",
      sort: "desc",
    },
  ]);

  useEffect(() => {
    dispatch(loadPurchaseOrders());
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, []);

  const rowDataPurchaseOrders = purchaseorders?.map((purchaseorder) => {
    return {
      id: purchaseorder?.id,
      rowId: purchaseorder?.rowId,
      vendorName: purchaseorder?.vendorName,
      purchaseDate: purchaseorder?.purchaseDate,
      advancePayment: purchaseorder?.advancePayment,
      totalCostPrice: purchaseorder?.totalCostPrice,
      duePayment: purchaseorder?.duePayment,
    };
  });

  const columns = useMemo(
    () => [
      { field: "id", headerName: "ID", flex: 0.5 },
      { field: "rowId", headerName: "rowID", flex: 0.5, sort: "desc" },
      {
        field: "SLNo",
        headerName: "SL. NO",
        flex: 0.5,
        filterable: false,
        renderCell: (index) => index.api.getRowIndex(index.row.id) + 1,
      },
      {
        field: "vendorName",
        headerName: "Vendor Name",
        flex: 1,
        cellClassName: "name-column--cell",
      },
      {
        field: "purchaseDate",
        headerName: "Date",
        flex: 1,
      },
      {
        field: "totalCostPrice",
        headerName: "Total",
        flex: 1,
      },
      {
        field: "advancePayment",
        headerName: "Advance",
        flex: 1,
      },
      {
        field: "duePayment",
        headerName: "Due",
        flex: 1,
      },
    ],
    []
  );

  return (
    <Box m="20px">
      <Header title="Purchase Orders" subtitle="List of Purchase Orders" />
      <Button
        variant="outlined"
        color="primary"
        startIcon={<AddIcon />}
        onClick={() => navigate("/purchaseorders")}
      >
        New Purchase
      </Button>
      <Box
        m="40px 0 0 0"
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
        <DataGrid
          rows={rowDataPurchaseOrders ?? []}
          columns={columns}
          sortModel={sortModel}
          onSortModelChange={(model) => setSortModel(model)}
          initialState={{
            columns: {
              columnVisibilityModel: {
                // Hide columns rowId and id, the other columns will remain visible
                rowId: false,
                id: false,
              },
            },
          }}
          getRowId={(rows) => rows.id}
          rowsPerPageOptions={[5, 10, 25]}
          pageSize={pageSize}
          onPageSizeChange={(newPageSize) => setPageSize(newPageSize)}
          getRowSpacing={(params) => ({
            top: params.isFirstVisible ? 0 : 5,
            bottom: params.isLastVisible ? 0 : 5,
          })}
          sx={{
            [`& .${gridClasses.row}`]: {
              bgcolor: (theme) =>
                theme.palette.mode === "light" ? grey[200] : grey[900],
            },
          }}
          components={{ Toolbar: GridToolbar }}
        />
      </Box>
    </Box>
  );
};

export default PurchaseMaster;
