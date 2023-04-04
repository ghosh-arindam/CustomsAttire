import { useState, useEffect, memo } from "react";
import { Box, TextField, MenuItem } from "@mui/material";
import { useDispatch, useSelector } from "react-redux";
import { loadProduct } from "../redux/action";

const ProductDropDownComponent = (props) => {
  const [fabricState, setFabricState] = useState();
  const { Products } = useSelector((state) => state.data);
  const dispatch = useDispatch();

  useEffect(() => {
    dispatch(loadProduct());
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, []);
  const handleSelectFabricChange = (event) => {
    console.log(event.target.value);
    // Here, we invoke the callback with the new value
    props.onChange(event.target.value);
    setFabricState(event.target.value);
  };
  return (
    <Box>
      <TextField
        id="outlined-select"
        select
        label="Fabric Code"
        variant="outlined"
        style={{ width: 300 }}
        onChange={handleSelectFabricChange}
        InputLabelProps={{
          shrink: true,
        }}
        value={fabricState || ""}
        defaultValue={""}
        name="fabricCode"
        sx={{ gridColumn: "span 4" }}
      >
        {Products?.map((d, index) => (
          <MenuItem
            key={index}
            value={JSON.stringify({
              name: d.fabricCode,
              description: d.description,
            })}
            //value={props.d.description}
          >
            {d.fabricCode} - {d.description}
          </MenuItem>
        ))}
        :<div></div>
      </TextField>
    </Box>
  );
};

export default memo(ProductDropDownComponent);
